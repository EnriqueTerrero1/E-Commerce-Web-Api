using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Entidades
{
    public class Direccion
    {

        [Key]

        public int Id { get; set; }
        public string direccion { get; set; }


      //  public Usuario usuario { get; set; }
    }
}
