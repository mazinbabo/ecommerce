using e_commerce.Aggregates.OrderAgg;
using e_commerce.BaseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Aggregates.CustomerAgg
{
    public class Customer : Entity
    {
        private readonly List<Order> _orders;
        private readonly List<Address> _addresses;

        public Customer(string firstName, string lastName, string email)
        {
            //TODO: Validate first and last name
            FirstName = firstName ?? throw new ArgumentNullException("firstName");
            LastName = lastName ?? throw new ArgumentNullException("lastName");
            Email = email ?? throw new ArgumentNullException("email");
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }


        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }

        public IEnumerable<Address> Addresses
        {
            get { return _addresses; }
        }


        public void UpdateCustomer(string firstName, string lastName)
        {
            // TODO: Validate 
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }
    }
}
