using AutoMapper;
using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Utilidades;
namespace EcommerceAPI.Controllers
{

    [ApiController]
    [Route("api/productos")]
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductoDTO>>> Get([FromQuery] PaginacionDTO paginacionDTO)
        {

            var queryable = context.Productos.AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnCabecera(queryable);
            var productos = await queryable.OrderBy(x => x.CategoriaId).Paginar(paginacionDTO).ToListAsync();
            var productoDTO = mapper.Map<List<ProductoDTO>>(productos);
            return productoDTO;

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductoDTO>> getById(int id)
        {
            var producto = await context.Productos.FirstOrDefaultAsync(x => x.Id == id);

            var productoDTO = mapper.Map<ProductoDTO>(producto);
            return productoDTO;


        }
        /*[HttpGet("paginar}")]
        public async Task<ActionResult<List<ProductoDTO>>>ObtenerProductosPaginados()
        {
            var cantidadDeProductosAMostrar = 3;
            
            var auxiliar=0;
            var productos = await context.productos.ToListAsync();
           var cantidadTotalDePagina = productos.Count()/cantidadDeProductosAMostrar;

            var productosAMostrar =  await context.productos.Take(cantidadDeProductosAMostrar).Skip(auxiliar).ToListAsync();
            return productoDTO;


        }*/
        [HttpPost]
        public async Task<ActionResult> Create( [FromForm] ProductoCreacionDTO productoCreacionDTO)
        {
            var producto = mapper.Map<Producto>(productoCreacionDTO);
            await context.Productos.AddAsync(producto);
            context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var producto = await context.Productos.FirstOrDefaultAsync(x => x.Id == id);
            context.Remove(producto);
            context.SaveChanges();


            return NoContent();
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult> put(int id, [FromBody] ProductoCreacionDTO productoCreacionDTO)
        {
            var producto = await context.Productos.FirstOrDefaultAsync(x => x.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            producto = mapper.Map(productoCreacionDTO, producto);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("filtrar/{CategoriaId:int}")]

        public async Task<ActionResult<List<ProductoDTO>>> getProductByCategories(int CategoriaId)
        {

            var productos = await context.Productos.Where(x => x.CategoriaId == CategoriaId).ToListAsync();

           var productosDTO = mapper.Map<List<ProductoDTO>>(productos);

            return productosDTO;

        }


    }
}
