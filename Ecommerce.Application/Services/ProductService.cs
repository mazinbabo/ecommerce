using AutoMapper;
using e_commerce.Aggregates.ProductAgg;
using e_commerce.Application.Dtos;
using Ecommerce.Application.Dtos;
using ECommerce.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProduct(NewProductDto newProductDto)
        {
            var product = new Product(newProductDto.Name, newProductDto.Discription, newProductDto.Price);
            var newproduct = await _unitOfWork.Products.Insert(product);
            _unitOfWork.Commit();
            return _mapper.Map<ProductDto>(newproduct);
        }

        public void DeleteProduct(int productId)
        {
            _unitOfWork.Products.Delete(productId);
        }

        public async Task<ProductDto> GetProduct(int productId, bool includeOrders = false)
        {
            var product = await _unitOfWork.Products.GetByID(productId);
            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            var products = await _unitOfWork.Products.Get();
            return _mapper.Map<List<Product>, List<ProductDto>>(products.ToList());
        }
    }
}
