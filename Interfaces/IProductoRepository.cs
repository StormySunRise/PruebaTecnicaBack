using TiendaOnlineAPI.Models.cs;

namespace TiendaOnlineAPI.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductosAsync();
        Task<Producto> GetProductoByIdAsync(int id);
        Task<IEnumerable<Categoria>> GetCategoriasAsync();
        Task AddFavoritoAsync(int productoId);
        Task RemoveFavoritoAsync(int productoId);
        Task<IEnumerable<Producto>> GetFavoritosAsync();
    }
}
