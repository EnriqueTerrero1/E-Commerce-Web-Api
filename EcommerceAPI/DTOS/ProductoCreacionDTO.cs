using EcommerceAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.DTOS
{
    public class ProductoCreacionDTO
    {
        public int CategoriaId { get; set; }
        [Required]

        public string Descripcion { get; set; }
        [Required]

        public int Precio { get; set; }
        [Required]

        public string Marca { get; set; }
        public string Imagen { get; set; }
    }
}
