using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Dtos
{
    public class NewOrderDto
    {
        public int CustomerId { get; set; }
        public List<NewOrderLineItemDto> OrderLineItems { get; set; }

        public int AddressId { get; set; }
    }
}
