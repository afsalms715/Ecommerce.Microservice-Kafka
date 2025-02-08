using AutoMapper;
using Ecommerce.Models;
using Ecommerce.OrderService.Dtos;

namespace Ecommerce.ProductService.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<OrderModel, OrderDto>().ReverseMap();
        }
    }
}
