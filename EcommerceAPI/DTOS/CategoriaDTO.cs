using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.DTOS
{
    public class CategoriaDTO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Longitud minima 5 caracteres")]
        public string Nombre { get; set; }
    }
}
