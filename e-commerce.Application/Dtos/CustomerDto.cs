using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Application.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public List<OrderDto> Orders { get; set; }
    }
}
