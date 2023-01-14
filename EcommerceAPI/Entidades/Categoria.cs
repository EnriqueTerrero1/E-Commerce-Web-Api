using EcommerceAPI.Validators;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Categoria
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [MinLength(5,ErrorMessage ="La longitud minima de este campo es de 5")]
        [PrimeraLetraMayuscula]

        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
