using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Aggregates.OrderAgg;
using e_commerce.Application.Dtos;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace e_commerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDto>> Get()
        {
            return await _orderService.GetOrders();
        }


        [HttpGet("{id}")]
        public async Task<OrderDto> Get(int id)
        {
            return await _orderService.GetOrder(id);
        }

        [HttpPost]
        public IActionResult Post(NewOrderDto newOrderDto)
        {
            //TODO: Validate
            var order = _orderService.CreateOrder(newOrderDto);
            return Ok(order);
        }

    }
}