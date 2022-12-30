using AutoMapper;
using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{

    [ApiController]
    [Route("api/carritos")]


    public class CarritoController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CarritoController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromForm] ElementoCarritoCreacionDTO carrito)
        {


            var elementoCarrito = mapper.Map<ElementoCarrito>(carrito);


           await  context.Carritos.AddAsync(elementoCarrito);

            context.SaveChangesAsync();

            return NoContent();


        }
        [HttpGet]

        public async Task<ActionResult<List<ElementoCarritoDTO>>> Get()

        {
            var usuarioId = 1;
            var elementosCarrito = await context.Carritos.Where(elemento => elemento.UsuarioId == usuarioId)
                .Include(x=>x.Producto)
                .ToListAsync();

            var elementoscarritoDTO = mapper.Map<List<ElementoCarritoDTO>>(elementosCarrito);
            

         //   context.Usuarios.Where(x => x.Id == usuarioId).Include(elementosCarrito;
            return elementoscarritoDTO;


        }

      /*  [HttpGet]

        public async Task<ActionResult<List<CarritoDTO>>> Get(int usuarioId)
        {

            var ElementosCarrito = await context.Carritos.Where(elemento => elemento.UsuarioId == usuarioId).ToListAsync();


            var CarritosDTO = mapper.Map<List<CarritoDTO>>(ElementosCarrito);

            return CarritosDTO;
        }
        */
    }
}
