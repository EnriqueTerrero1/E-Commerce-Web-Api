using EcommerceAPI.Entidades;

namespace EcommerceAPI.DTOS
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public int Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Marca { get; set; }
        public string Imagen { get; set; }
    }
}
