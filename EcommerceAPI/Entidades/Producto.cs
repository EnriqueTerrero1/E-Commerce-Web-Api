using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int CategoriaId { get; set; }

        [Required]
        public string Descripcion { get; set; }
        [Required]

        public int Precio { get; set; }
        [Required]

        public string Marca { get; set; }
        public string Imagen { get; set; }

        public List<ElementoCarrito> elementoCarritos { get; set; }


    }
}
