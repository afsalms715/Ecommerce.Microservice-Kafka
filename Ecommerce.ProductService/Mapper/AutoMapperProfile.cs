using AutoMapper;
using Ecommerce.Models;
using Ecommerce.ProductService.Dtos;

namespace Ecommerce.ProductService.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductModel, ProductDto>().ReverseMap();
        }
    }
}
