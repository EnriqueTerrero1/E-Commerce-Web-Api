using AutoMapper;
using EcommerceAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
 {
    public class OrdenController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        /*  public OrdenController(ApplicationDbContext context , IMapper mapper)
         {

             this.mapper = mapper;
             this.context = context;
         }

         [HttpPost]
        public async Task<ActionResult> Create()
        {
          var usuarioId = 1;
            var elementosEnCarritos = await context.Carritos.Where(elemento => elemento.UsuarioId == usuarioId).Include(x => x.Producto).ToListAsync();

            var ordenDTO = new Orden
            {
                UsuarioId = usuarioId,
                elementoCarritos = elementosEnCarritos

            };

            await context.Ordenes.AddAsync(ordenDTO);

            foreach (var elemento in elementosEnCarritos)
            {


            }
            return NoContent();


    }*/
    }
}
