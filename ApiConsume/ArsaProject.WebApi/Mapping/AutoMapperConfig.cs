using ArsaProject.DtoLayer.Dtos.ProductDto;
using ArsaProject.EntityLayer.Concrete;
using AutoMapper;

namespace ArsaProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();

            CreateMap<UpdateProductDto,Product>().ReverseMap();
            
        }
    }
}
