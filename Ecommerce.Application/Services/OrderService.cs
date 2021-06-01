using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using e_commerce.Aggregates.OrderAgg;
using e_commerce.Application.Dtos;
using e_commerce.Application.Helpers;
using Ecommerce.Application.Dtos;
using ECommerce.Data.UnitOfWork;

namespace Ecommerce.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public async Task<OrderDto> CreateOrder(NewOrderDto newOrderDto)
        {
            //TODO: add transaction
            var order = new Order(newOrderDto.CustomerId);
            var newOrder = await _unitOfWork.Orders.Insert(order);
            foreach(var item in newOrderDto.OrderLineItems)
            {
                order.AddOrderLineItem(item.ProductId, item.Quantity);
            }
            _unitOfWork.Commit();
            return _mapper.Map<OrderDto>(newOrder);
        }

        public void DeleteOrder(int addressId)
        {
            _unitOfWork.Addresses.Delete(addressId);
        }

        public async Task<OrderDto> GetOrder(int addressId)
        {
            var order = await _unitOfWork.Orders.GetByID(addressId);
            return _mapper.Map<Order, OrderDto>(order);
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            var orders = await _unitOfWork.Orders.Get();
            return _mapper.Map<List<Order>, List<OrderDto>>(orders.ToList());
        }

    }
}
