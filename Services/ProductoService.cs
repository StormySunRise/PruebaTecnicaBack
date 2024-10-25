using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Data;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;
using TiendaOnlineAPI.Models.cs;
using TiendaOnlineAPI.Repositories;

namespace TiendaOnlineAPI.Services
{
    public class ProductoService : IProductoService
    {
        private readonly TiendaOnlineContext _context;
        public ProductoService(TiendaOnlineContext context)
        {
            _context = context;
        }

        public async Task<List<ProductoDto>> GetProductosAsync()
        {
            return await _context.Productos.Select(p => new ProductoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                Descripcion = p.Descripcion,
                categoriaId = p.CategoriaId
            }).ToListAsync();
        }

        public async Task<ProductoDto> GetProductoByIdAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return null;

            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Descripcion = producto.Descripcion,
                categoriaId = producto.CategoriaId
            };
        }
    }
}
