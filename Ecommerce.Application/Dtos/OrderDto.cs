using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public int CustomerId { get; set; }

        public CustomerDto Customer { get; set; }

        public List<OrderLineItemDto> OrderLineItems { get; set; }
    }
}
