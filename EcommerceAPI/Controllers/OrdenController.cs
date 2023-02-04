using AutoMapper;
using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;
using EcommerceAPI.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
 {

    [Route("api/ordenes")]
    [ApiController]
    public class OrdenController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public OrdenController(ApplicationDbContext context, IMapper mapper)
        {

            this.mapper = mapper;
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder( double total)
        {
          var usuarioId = 9;

            var ordenDTO = new Orden
            {
                UsuarioId = usuarioId,
                fecha = DateTime.Today,
                Total = total

            };

           var orden= await context.Ordenes.AddAsync(ordenDTO);

            context.SaveChanges();

            addOrderDetail(orden.Entity.Id);
           
            return NoContent();


    }

        [HttpGet]
        public async Task<List<OrdenDTO>> GetOrders()
        {


            var ordenes = await context.Ordenes.Include(x => x.OrdenDetalles).ThenInclude(x=>x.Producto).ToListAsync();

          var ordenesDTO=  mapper.Map<List<OrdenDTO>>(ordenes);

            return ordenesDTO;
        }
        private  async void  addOrderDetail(int id)
        {
            var usuarioId = 9;
            var elementosEnCarritos =  context.Carritos.Where(elemento => elemento.UsuarioId == usuarioId).Include(x => x.Producto).ToList();

            var ordenesDetalles = mapper.Map<List<OrdenDetalle>>(elementosEnCarritos);

                foreach( var orden in ordenesDetalles)
            {
                
                    orden.OrdenId = id;
                
            }
           await  context.OrdenDetalles.AddRangeAsync(ordenesDetalles);

            context.SaveChanges();


        }
    }
}
