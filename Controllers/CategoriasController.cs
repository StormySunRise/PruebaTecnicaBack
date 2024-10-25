using Microsoft.AspNetCore.Mvc;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;

namespace TiendaOnlineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaDto>>> GetCategorias()
        {
            var categorias = await _categoriaService.GetCategoriasAsync();
            return Ok(categorias);
        }
    }
}
