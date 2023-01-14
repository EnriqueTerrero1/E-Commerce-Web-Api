namespace EcommerceAPI.Entidades
{
    public class OrdenDetalle
    {

        public int Id { get; set; }


        public int Cantidad { get; set; }

        public int ProductoId { get; set; }

        public int UsuarioId { get; set; }

        public int OrdenId { get; set; }
        public Producto Producto { get; set; }

    }
}
