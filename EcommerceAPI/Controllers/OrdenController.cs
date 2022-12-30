using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;
using Microsoft.AspNetCore.Mvc;



namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/Orden")]
    public class OrdenController : Controller
    {

        public OrdenController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<ElementoCarrito> carritos = new List<ElementoCarrito>();
        private readonly ApplicationDbContext context;

        /* [HttpPost]
         public async Task<ActionResult> Create(CategoriaCreacionDTO categoriaCreacionDTO)
         {

             context.carritos.
         }*/
    }
}
