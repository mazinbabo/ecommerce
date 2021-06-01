using e_commerce.Application.Dtos;
using System;
using System.Collections.Generic;

namespace Ecommerce.Application.Services
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public int CustomerId { get; set; }

    }
}