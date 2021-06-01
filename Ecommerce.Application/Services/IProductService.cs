using e_commerce.Application.Dtos;
using Ecommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProducts();

        Task<ProductDto> GetProduct(int productId, bool includeOrders = false);

        Task<ProductDto> CreateProduct(NewProductDto newProductDto);

        void DeleteProduct(int customerId);
    }
}
