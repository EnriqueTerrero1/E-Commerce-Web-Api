using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Orden
    {

        [Key]
        public string Id { get; set; }
        public Usuario Usuario { get; set; }
        public IEnumerable<ElementoCarrito> Carritos { get; set; }
        public int Cantidad { get; set; }

        public string Direccion { get; set; }

        public string FechaCompra { get; set; }

        public string Telefono { get; set; }

    }
}
