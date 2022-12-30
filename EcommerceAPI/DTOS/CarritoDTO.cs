namespace EcommerceAPI.DTOS
{
    public class CarritoDTO
    {

        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public int Cantidad { get; set; }

        public int ProductoId { get; set; }
    }
}
