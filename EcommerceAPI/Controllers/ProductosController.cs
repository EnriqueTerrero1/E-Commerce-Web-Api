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
        private readonly ILogger<ProductosController> logger;

        public ProductosController(ApplicationDbContext context, IMapper mapper, ILogger<ProductosController>logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductoDTO>>> Get([FromQuery] PaginacionDTO paginacionDTO)
        {
            logger.LogInformation("Product added"+ DateTime.UtcNow.ToString());


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
       
        [HttpPost]
        public async Task<ActionResult> Create( [FromForm] ProductoCreacionDTO productoCreacionDTO)
        {
           
            var producto = mapper.Map<Producto>(productoCreacionDTO);

            await context.Productos.AddAsync(producto);
            context.SaveChanges();
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

             context.SaveChanges();
            return NoContent();
        }

        [HttpGet("filtrar/{CategoriaId:int}")]

        public async Task<ActionResult<List<ProductoDTO>>> getProductByCategories(int CategoriaId)
        {

           
                var productos = await SearchProductByCategories(CategoriaId);
           

                var productosDTO = mapper.Map<List<ProductoDTO>>(productos);
            
            return productosDTO;

        }

        [HttpGet("buscar/{elementoABuscar}")]

        public async Task<ActionResult<List<ProductoDTO>>> SearchProduct(string? elementoABuscar)
        {

            var elementosEncontrados = context.Productos.Where(x => x.Marca.Contains(elementoABuscar) || x.Descripcion.Contains(elementoABuscar));


                elementosEncontrados = context.Productos;
           

                var elementosEncontradosDTO = mapper.Map<List<ProductoDTO>>(elementosEncontrados);

                return elementosEncontradosDTO;


        }

        [HttpGet("buscar")]


        private async Task<List<Producto>> SearchProductByCategories (int categoriaId)
        {

           
                var productos = await context.Productos.Where(x => x.CategoriaId == categoriaId).ToListAsync();

                return productos;
            

            
        }
        


    }
}
