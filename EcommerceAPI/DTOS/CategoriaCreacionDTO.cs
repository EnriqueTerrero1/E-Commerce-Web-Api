using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.DTOS
{
    public class CategoriaCreacionDTO
    {
        [Required]
        public string Nombre { get; set; }
    }
}
