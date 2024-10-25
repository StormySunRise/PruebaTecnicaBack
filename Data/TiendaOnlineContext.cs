using Microsoft.EntityFrameworkCore;
using TiendaOnlineAPI.Models.cs;

namespace TiendaOnlineAPI.Data
{
    public class TiendaOnlineContext : DbContext
    {
        public TiendaOnlineContext(DbContextOptions<TiendaOnlineContext> options)
       : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Favorito>()
        //        .HasKey(f => new { f.ProductoId });
        //}
    } 
}
