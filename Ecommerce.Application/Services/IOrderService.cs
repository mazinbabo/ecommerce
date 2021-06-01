using e_commerce.Aggregates.OrderAgg;
using e_commerce.Application.Dtos;
using Ecommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetOrders();

        Task<OrderDto> GetOrder(int orderId);

        Task<OrderDto> CreateOrder(NewOrderDto newOrderDto);


        void DeleteOrder(int orderId);
    }
}
