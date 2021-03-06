using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Dtos
{
    public class NewAddressDto
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string LineAddress { get; set; }

        public int CustomerId { get; set; }
    }
}
