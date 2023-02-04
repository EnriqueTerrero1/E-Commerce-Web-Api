using EcommerceAPI.Entidades;

namespace EcommerceAPI.DTOS
{
    public class OrdenDTO
    {

        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public double Total { get; set; }
        public DateTime fecha { get; set; }

        public Usuario Usuario { get; set; }
        public List<OrdenDetalle> OrdenDetalles { get; set; }
    }
}
