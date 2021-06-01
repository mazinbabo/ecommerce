using e_commerce.BaseTypes;

namespace e_commerce.Aggregates.ProductAgg
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string Discription { get; set; }

        public decimal Price { get; set; }

        public int AvailableQuantity { get; set; }

        public Product()
        {

        }

        public Product(string name, string description, decimal price)
        {
            Name = name;
            Discription = description;
            Price = price;
        }
    }
}
