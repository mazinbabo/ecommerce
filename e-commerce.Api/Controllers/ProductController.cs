using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _service = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            return await _service.GetProducts();
        }


        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            return await _service.GetProduct(id);
        }

        [HttpPost]
        public IActionResult Post(NewProductDto newProductDto)
        {
            //TODO: Validate
            var order = _service.CreateProduct(newProductDto);
            return Ok(order);
        }
    }
}