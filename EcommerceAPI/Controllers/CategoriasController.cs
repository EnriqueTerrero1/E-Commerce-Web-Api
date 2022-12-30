using AutoMapper;
using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/categorias")]
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public  async Task <ActionResult> Create(CategoriaCreacionDTO categoriaCreacionDTO)
        {

            var categoria = mapper.Map<Categoria>(categoriaCreacionDTO);

            await context.Categorias.AddAsync(categoria);

            context.SaveChangesAsync();

            return NoContent();

           
        }

        [HttpGet]

        public async Task <ActionResult<List<CategoriaDTO>>> GetAll()
        {
            var categorias = await context.Categorias.ToListAsync();

            var categoriasDTO= mapper.Map<List<CategoriaDTO>>(categorias);
            return categoriasDTO;

        }

        [HttpDelete("{id:int}")]

        public async Task <ActionResult>Delete(int id)
        {
            var producto = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
             context.Categorias.Remove(producto);
                context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<CategoriaDTO>>GetById(int id)
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
           var categoriaDTO= mapper.Map<CategoriaDTO>(categoria);
            return categoriaDTO;
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> put(int id, [FromBody] CategoriaCreacionDTO categoriaCreacionDTO)
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            categoria = mapper.Map(categoriaCreacionDTO, categoria);

            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
