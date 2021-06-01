using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Dtos
{
    public class NewOrderLineItemDto
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
