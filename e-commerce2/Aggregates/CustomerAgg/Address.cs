using e_commerce.BaseTypes;

namespace e_commerce.Aggregates.CustomerAgg
{
    public class Address : Entity
    {
        public string Country { get; set; }
        
        public string City { get; set; }
        
        public string PostCode { get; set; }
        
        public string LineAddress { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Address(string country, string city,string postCode,string lineAddress, int customerId)
        {
            Country = country;
            City = city;
            PostCode = postCode;
            LineAddress = lineAddress;
            CustomerId = customerId;
        }
    }
}