using TiendaOnlineAPI.DTOs;

namespace TiendaOnlineAPI.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<CategoriaDto>> GetCategoriasAsync();
    }
}
