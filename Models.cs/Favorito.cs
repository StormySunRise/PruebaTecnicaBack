namespace TiendaOnlineAPI.Models.cs
{
    public class Favorito
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
