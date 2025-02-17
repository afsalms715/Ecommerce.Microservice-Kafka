using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Interface;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Queris;
using MediatR;

namespace Ecommerce.ProductService.Handlers
{
    public class GetProductByIdQueryHandler(IBaseRepository<ProductModel> prouctRepository, IMapper mapper) : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await prouctRepository.Get(request.Id);
            return mapper.Map<ProductDto>(product);
        }
    }
}
