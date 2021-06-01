using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Application.Dtos;
using e_commerce.Application.Services;
using Ecommerce.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace e_commerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _service = customerService;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            return await _service.GetCustomers();
        }


        // GET api/<Orders>/5
        [HttpGet("{id}")]
        public async Task<CustomerDto> Get(int id)
        {
            return await _service.GetCustomer(id);
        }

        [HttpPost]
        public IActionResult Post(NewCustomerDto newAdressDto)
        {
            //TODO: Validate
            var order = _service.CreateCustomer(newAdressDto);
            return Ok(order);
        }
    }
}
