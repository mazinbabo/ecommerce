using AutoMapper;
using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Aggregates.OrderAgg;
using e_commerce.Aggregates.ProductAgg;
using e_commerce.Application.Dtos;
using Ecommerce.Application.Dtos;
using System;

namespace e_commerce.Application.Helpers
{
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<NewOrderDto, OrderDto>();
            CreateMap<NewOrderLineItemDto, OrderLineItemDto>();
            CreateMap<OrderLineItemDto, OrderLineItem>();
            CreateMap<OrderLineItem, OrderLineItemDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();
            
            // Additional mappings here...
        }
    }
}
