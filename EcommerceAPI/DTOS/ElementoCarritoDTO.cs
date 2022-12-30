using EcommerceAPI.Entidades;

namespace EcommerceAPI.DTOS
{
    public class ElementoCarritoDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int Cantidad { get; set; }

        public ProductoDTO Producto { get; set; }
    }
}
