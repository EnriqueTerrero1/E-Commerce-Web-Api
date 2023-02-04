using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public int direccionId { get; set; }

        public Direccion direccion { get; set; }

        public List<ElementoCarrito> elementoCarritos { get; set; }

        public List<OrdenDetalle> ordenDetalles { get; set; }

        public List<Orden> Ordenes { get; set; }

    }
}
