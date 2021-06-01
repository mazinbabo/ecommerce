using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Dtos
{
    public class NewProductDto
    {
        public string Name { get; set; }

        public string Discription { get; set; }

        public decimal Price { get; set; }
    }
}
