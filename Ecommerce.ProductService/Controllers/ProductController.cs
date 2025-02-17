using Ecommerce.Models;
using Ecommerce.Models.General;
using Ecommerce.Models.Interface;
using Ecommerce.ProductService.Dtos;
using Ecommerce.ProductService.Queris;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ProductService.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator, IBaseRepository<ProductModel> productRepository)
        {
            _mediator = mediator;
        }

        [HttpGet("get_all_products")]
        public async Task<ActionResult<Envelope<List<ProductDto>>>> GetAllProducts()
        {
            var response = new Envelope<List<ProductDto>>();
            var data = await _mediator.Send(new GetProductListQuery());
            if (data != null)
            {
                response.StatusCode = 200;
                response.Data = data;
                response.Message = "Success";
            }
            else
            {
                response.StatusCode = 400;
                response.Data = null;
                response.Message = "Not Found";
            }
            return Ok(response);
        }

        [HttpGet("get_product_by_id")]
        public async Task<ActionResult<Envelope<ProductDto>>> GetProductById([FromQuery] GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var response = new Envelope<ProductDto>();
            var data = await _mediator.Send(request, cancellationToken);
            if (data != null)
            {
                response.StatusCode = 200;
                response.Data = data;
                response.Message = "Success";
            }
            else
            {
                response.StatusCode = 400;
                response.Data = null;
                response.Message = "Not Found";
            }
            return Ok(response);
        }
    }
}
