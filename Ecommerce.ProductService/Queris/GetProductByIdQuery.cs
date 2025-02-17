using Ecommerce.ProductService.Dtos;
using MediatR;

namespace Ecommerce.ProductService.Queris;
public sealed record GetProductByIdQuery(int Id) : IRequest<ProductDto>;
