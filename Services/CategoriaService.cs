using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Data;
using TiendaOnlineAPI.DTOs;
using TiendaOnlineAPI.Interfaces;

namespace TiendaOnlineAPI.Services
{
    public class CategoriaService : ICategoriaService

    {
        private readonly TiendaOnlineContext _context;

        public CategoriaService(TiendaOnlineContext context)
        {
            _context = context;
        }

        public async Task<List<CategoriaDto>> GetCategoriasAsync()
        {
            return await _context.Categorias.Select(c => new CategoriaDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
            }).ToListAsync();
        }
    }
}
