using Ecommerce.OrderService.Dtos;
using MediatR;

namespace Ecommerce.OrderService.Queries;
public sealed record GetAllOrdersQuery : IRequest<List<OrderDto>>;

