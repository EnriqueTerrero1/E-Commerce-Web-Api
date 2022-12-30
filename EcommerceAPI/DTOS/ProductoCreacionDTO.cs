using EcommerceAPI.Entidades;

namespace EcommerceAPI.DTOS
{
    public class ProductoCreacionDTO
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Marca { get; set; }
        public string Imagen { get; set; }
    }
}
