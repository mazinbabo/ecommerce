using e_commerce.Aggregates.ProductAgg;
using e_commerce.BaseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Aggregates.OrderAgg
{
    public class OrderLineItem : Entity
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Cost
        {
            get
            {
                return Quantity * Product.Price;
            }
        }

        public OrderLineItem(int orderId, int productId, int quantity)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
