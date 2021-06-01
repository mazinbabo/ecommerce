using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Country { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string LineAddress { get; set; }

        public int CustomerId { get; set; }
    }
}
