namespace EcommerceAPI.Entidades
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<ElementoCarrito> elementoCarritos { get; set; }
    }
}
