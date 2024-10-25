using Microsoft.AspNetCore.Mvc;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;

namespace TiendaOnlineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoritosController : ControllerBase
    {
        private readonly IFavoritoService _favoritoService;

        public FavoritosController(IFavoritoService favoritoService)
        {
            _favoritoService = favoritoService;
        }

        [HttpPost("{productoId}")]
        public async Task<ActionResult<FavoritoDTo>> AddFavorito(int productoId)
        {
            var favorito = await _favoritoService.AddFavoritoAsync(productoId);
            return CreatedAtAction(nameof(GetFavoritos), new { id = favorito.Id }, favorito);
        }

        [HttpDelete("{productoId}")]
        public async Task<IActionResult> RemoveFavorito(int productoId)
        {
            await _favoritoService.RemoveFavoritoAsync(productoId);
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<FavoritoDTo>>> GetFavoritos()
        {
            var favoritos = await _favoritoService.GetFavoritosAsync();
            return Ok(favoritos);
        }
    }
}
