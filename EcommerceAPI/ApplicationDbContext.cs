using EcommerceAPI.Entidades;
//using EcommerceAPI.Migrations;
using Microsoft.EntityFrameworkCore;
using Usuario = EcommerceAPI.Entidades.Usuario;

namespace EcommerceAPI
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

      // public DbSet<OrdenDetalle> OrdenDetalles { get; set; }
      //  public DbSet<Orden> Ordenes { get; set; }

        public DbSet<ElementoCarrito> Carritos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
