using TiendaOnlineAPI.DTOs;

namespace TiendaOnlineAPI.Interfaces
{
    public interface IFavoritoService
    {
        Task<FavoritoDTo> AddFavoritoAsync(int productoId);
        Task RemoveFavoritoAsync(int productoId);
        Task<List<FavoritoDTo>> GetFavoritosAsync();
    }
}
