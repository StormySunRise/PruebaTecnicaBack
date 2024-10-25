using System.ComponentModel.DataAnnotations;

namespace TiendaOnlineAPI.DTOs
{
    public class ProductoDto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion {  get; set; }
        public int categoriaId { get; set; }

    }
}
