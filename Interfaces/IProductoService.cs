using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Models.cs;

namespace TiendaOnlineAPI.Interfaces
{
    public interface IProductoService
    {
        Task<List<ProductoDto>> GetProductosAsync();
        Task<ProductoDto> GetProductoByIdAsync(int id);
    }
}
