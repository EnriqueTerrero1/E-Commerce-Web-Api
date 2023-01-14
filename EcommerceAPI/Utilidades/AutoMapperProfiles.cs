using AutoMapper;
using EcommerceAPI.DTOS;
using EcommerceAPI.Entidades;

namespace EcommerceAPI.Utilidades
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductoCreacionDTO,Producto>().ReverseMap();
            CreateMap<CategoriaCreacionDTO, Categoria>();
            CreateMap<Categoria,CategoriaDTO>();
           CreateMap<ElementoCarrito,ElementoCarritoDTO>().ReverseMap();
            CreateMap<ProductoDTO, Producto>().ReverseMap();
            CreateMap<ElementoCarritoCreacionDTO, ElementoCarrito>();
                

           
        }

    }
}
