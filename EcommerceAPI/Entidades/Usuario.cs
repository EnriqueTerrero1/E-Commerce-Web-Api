namespace EcommerceAPI.Entidades
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public List<ElementoCarrito> elementoCarritos { get; set; }

        public List<OrdenDetalle> ordens { get; set; }

    }
}
