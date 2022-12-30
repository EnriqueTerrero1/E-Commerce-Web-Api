using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Marca { get; set; }
        public string Imagen { get; set; }

        public List<ElementoCarrito> elementoCarritos { get; set; }

    }
}
