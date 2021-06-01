using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public decimal Price { get; set; }
    }
}
