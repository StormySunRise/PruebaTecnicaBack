//using Microsoft.EntityFrameworkCore;
//using TiendaOnlineAPI.Data;
//using TiendaOnlineAPI.Models.cs;

//namespace TiendaOnlineAPI.Repositories
//{
//    public class ProductoRepository : IProductoRepository
//    {
//        private readonly TiendaOnlineContext _context;

//        public ProductoRepository(TiendaOnlineContext context)
//        {
//            _context = context;
//        }

//        public async Task<IEnumerable<Producto>> GetProductosAsync()
//        {
//            return await _context.Productos.Include(p => p.Categoria).ToListAsync();
//        }

//        public async Task<Producto> GetProductoByIdAsync(int id)
//        {
//            return await _context.Productos.Include(p => p.Categoria)
//                                            .FirstOrDefaultAsync(p => p.Id == id);
//        }

//        public async Task<IEnumerable<Categoria>> GetCategoriasAsync()
//        {
//            return await _context.Categorias.ToListAsync();
//        }

//        public async Task AddFavoritoAsync(int productoId)
//        {
//            var favorito = new Favorito { ProductoId = productoId };
//            await _context.Favoritos.AddAsync(favorito);
//            await _context.SaveChangesAsync();
//        }

//        public async Task RemoveFavoritoAsync(int productoId)
//        {
//            var favorito = await _context.Favoritos.FirstOrDefaultAsync(f => f.ProductoId == productoId);
//            if (favorito != null)
//            {
//                _context.Favoritos.Remove(favorito);
//                await _context.SaveChangesAsync();
//            }
//        }

//        public async Task<IEnumerable<Producto>> GetFavoritosAsync()
//        {
//            var favoritos = await _context.Favoritos.Select(f => f.Producto).Include(p => p.Categoria).ToListAsync();
//            return favoritos;
//        }
//    }
//}
