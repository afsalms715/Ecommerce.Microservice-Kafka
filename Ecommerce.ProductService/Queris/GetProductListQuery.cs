using Ecommerce.ProductService.Dtos;
using MediatR;

namespace Ecommerce.ProductService.Queris;
public sealed record GetProductListQuery() : IRequest<List<ProductDto>>;
