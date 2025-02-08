using Ecommerce.Models;
using Ecommerce.Models.General;
using Ecommerce.Models.Interface;
using Ecommerce.OrderService.Dtos;
using Ecommerce.OrderService.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.OrderService.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("get_orders")]
        public async Task<ActionResult<Envelope<List<OrderDto>>>> GetIrders()
        {
            var response = new Envelope<List<OrderDto>>();
            var data = await _mediator.Send(new GetAllOrdersQuery());
            response.Data = data;
            response.StatusCode = 200;
            response.Message = "OK";
            return Ok(response);
        }
    }
}
