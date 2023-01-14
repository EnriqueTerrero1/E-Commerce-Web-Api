using EcommerceAPI.Validators;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.DTOS
{
    public class CategoriaCreacionDTO
    {
        [Required]
        [MinLength(5,ErrorMessage ="Longitud minima 5 caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
