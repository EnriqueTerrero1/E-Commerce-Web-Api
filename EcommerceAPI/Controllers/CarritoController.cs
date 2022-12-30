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


            await context.Carritos.AddAsync(elementoCarrito);

            context.SaveChangesAsync();

            return NoContent();


        }
        [HttpGet]

        public async Task<ActionResult<List<ElementoCarritoDTO>>> Get()

        {
            var usuarioId = 1;
            var elementosCarrito = await context.Carritos.Where(elemento => elemento.UsuarioId == usuarioId)
                .Include(x => x.Producto)
                .ToListAsync();

            var elementoscarritoDTO = mapper.Map<List<ElementoCarritoDTO>>(elementosCarrito);

            return elementoscarritoDTO;
        }

        [HttpDelete]

        public async Task<ActionResult> Delete(int id)
        {

            var elemento = await context.Carritos.FirstOrDefaultAsync(x => x.Id == id);

            context.Carritos.Remove(elemento);

            context.SaveChangesAsync();
            return NoContent();

        }

        [HttpGet ("{id:int}")]
        public async Task<ActionResult<ElementoCarritoDTO>> getById (int id)
            {

            var elemento = await context.Carritos.Include(x=>x.Producto).FirstOrDefaultAsync(x => x.Id == id);

          var  elementoDTO = mapper.Map<ElementoCarritoDTO>(elemento);

            return elementoDTO;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> put(int id, [FromBody] ElementoCarritoDTO elementoCarritoDTO)
        {
            var elemento = await context.Carritos.Include(x=>x.Producto).FirstOrDefaultAsync(x => x.Id == id);
            if (elemento == null)
            {
                return NotFound();
            }
            elemento = mapper.Map(elementoCarritoDTO, elemento);

            await context.SaveChangesAsync();
            return NoContent();
        }


    }
}
