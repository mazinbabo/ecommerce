using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Application.Dtos
{
    public class OrderLineItemDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public OrderDto Order { get; set; }

        public int ProductId { get; set; }

        public ProductDto Product { get; set; }

        public int Quantity { get; set; }
    }
}
