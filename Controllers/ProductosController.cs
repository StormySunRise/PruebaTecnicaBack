using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Data;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;
using TiendaOnlineAPI.Models.cs;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly IProductoService _productoService;

    public ProductosController(IProductoService productoService)
    {
        _productoService = productoService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProductoDto>>> GetProductos()
    {
        var productos = await _productoService.GetProductosAsync();
        return Ok(productos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductoDto>> GetProducto(int id)
    {
        var producto = await _productoService.GetProductoByIdAsync(id);
        if (producto == null) return NotFound();
        return Ok(producto);
    }
}
