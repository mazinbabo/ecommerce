using e_commerce.Aggregates.CustomerAgg;
using e_commerce.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_commerce.Aggregates.OrderAgg
{
    public class Order : Entity
    {
        private readonly List<OrderLineItem> _orderLineItems = new List<OrderLineItem>();

        public Order(int customerId)
        {
            CustomerId = customerId;
            Status = OrderStatus.New;
        }

        public Order(int customerId, List<OrderLineItem> orderLineItems)
        {
            CustomerId = customerId;
            _orderLineItems = orderLineItems;
            OrderNo = GetNextNumber();
            OrderDate = DateTime.UtcNow;
            Status = OrderStatus.Submitted;
        }


        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }


        public OrderStatus Status { get; set; }


        public IEnumerable<OrderLineItem> OrderLineItems
        {
            get { return _orderLineItems; }
        }

        public void AddOrderLineItem(int productId, int Quantity)
        {
            var item = new OrderLineItem(Id, productId, Quantity);
            _orderLineItems.Add(item);
        }

        public decimal CalculateTotal()
        {
            var sum = _orderLineItems.Sum(x => x.Cost);
            return sum;
        }

        private string GetNextNumber()
        {
            var rd = new Random().Next(0, 100);
            return $"ORDER#{rd}";
        }



    }
}
