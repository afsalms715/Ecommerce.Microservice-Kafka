using Ecommerce.Models.Interface;
using Ecommerce.Models;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Queris;
using MediatR;
using AutoMapper;

namespace Ecommerce.ProductService.Handlers
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<ProductDto>>
    {
        private readonly IBaseRepository<ProductModel> _productRepository;
        private readonly IMapper _mapper;
        public GetProductListHandler(IBaseRepository<ProductModel> prouctRepository, IMapper mapper)
        {
            _productRepository = prouctRepository;
            _mapper = mapper;
        }
        public async Task<List<ProductDto>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetAll();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
