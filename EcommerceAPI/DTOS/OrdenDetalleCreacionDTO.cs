namespace EcommerceAPI.DTOS
{
    public class OrdenDetalleCreacionDTO
    {

        public int Cantidad { get; set; }

        public int ProductoId { get; set; }

        public int UsuarioId { get; set; }

        public int OrdenId { get; set; }
    }
}
