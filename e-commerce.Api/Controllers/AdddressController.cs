using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace e_commerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AdddressController : Controller
    {
        private readonly IAddressService _service;

        private readonly ILogger<AdddressController> _logger;

        public AdddressController(ILogger<AdddressController> logger, IAddressService addressService)
        {
            _logger = logger;
            _service = addressService;
        }

        [HttpGet]
        public async Task<IEnumerable<AddressDto>> Get()
        {
            return await _service.GetAddresses();
        }


        [HttpGet("{id}")]
        public async Task<AddressDto> Get(int id)
        {
            return await _service.GetAddress(id);
        }

        [HttpPost]
        public IActionResult Post(NewAddressDto newAdressDto)
        {
            //TODO: Validate
            var order = _service.CreateAddress(newAdressDto);
            return Ok(order);
        }
    }
}