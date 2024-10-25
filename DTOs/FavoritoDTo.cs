namespace TiendaOnlineAPI.DTOs
{
    public class FavoritoDTo
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public ProductoDto Producto { get; set; }
    }
}
