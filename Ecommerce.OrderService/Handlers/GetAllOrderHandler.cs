using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Interface;
using Ecommerce.OrderService.Dtos;
using Ecommerce.OrderService.Queries;
using MediatR;

namespace Ecommerce.OrderService.Handlers
{
    public class GetAllOrderHandler(IBaseRepository<OrderModel> _baseRepository, IMapper _mapper) : IRequestHandler<GetAllOrdersQuery, List<OrderDto>>
    {
        public async Task<List<OrderDto>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<OrderDto>>(await _baseRepository.GetAll());
        }
    }
}
