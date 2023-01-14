using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class ElementoCarrito
    {
        
        public int Id { get; set; }

        
        public int Cantidad { get; set; }

        public int ProductoId { get; set; }

        public int UsuarioId { get; set; }


        public Producto Producto { get; set; }
        public Usuario usuario { get; set; }

       

    }
}
