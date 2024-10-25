using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Data;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;
using TiendaOnlineAPI.Models.cs;

namespace TiendaOnlineAPI.Services
{
    public class FavoritoService : IFavoritoService
    {
        private readonly TiendaOnlineContext _context;

        public FavoritoService(TiendaOnlineContext context)
        {
            _context = context;
        }

        public async Task<FavoritoDTo> AddFavoritoAsync(int productoId)
        {
            var favorito = new Favorito { ProductoId = productoId };
            await _context.Favoritos.AddAsync(favorito);
            await _context.SaveChangesAsync();

            var producto = await _context.Productos.FindAsync(productoId);
            return new FavoritoDTo
            {
                Id = favorito.Id,
                ProductoId = productoId,
                Producto = new ProductoDto
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Precio = producto.Precio
                }
            };
        }

        public async Task RemoveFavoritoAsync(int productoId)
        {
            var favorito = await _context.Favoritos.FirstOrDefaultAsync(f => f.Id == productoId);
            if (favorito != null)
            {
                _context.Favoritos.Remove(favorito);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<FavoritoDTo>> GetFavoritosAsync()
        {
            return await _context.Favoritos.Include(f => f.Producto)
                .Select(f => new FavoritoDTo
                {
                    Id = f.Id,
                    ProductoId = f.ProductoId,
                    Producto = new ProductoDto
                    {
                        Id = f.Producto.Id,
                        Nombre = f.Producto.Nombre,
                        Precio = f.Producto.Precio
                    }
                }).ToListAsync();
        }
    }
}
