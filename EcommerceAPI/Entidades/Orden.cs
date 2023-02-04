using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Orden
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public double Total { get; set; }

        public DateTime fecha { get; set; }

        public Usuario Usuario { get; set; }
        public List<OrdenDetalle> OrdenDetalles { get; set; }

        //public List<ElementoCarrito>elementoCarritos { get; set; }
    }
}
