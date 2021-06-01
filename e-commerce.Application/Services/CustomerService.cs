using System;
using System.Collections.Generic;
using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Application.Dtos;
using e_commerce.Application.Helpers;

namespace e_commerce.Application.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerDto CreateCustomer(NewCustomerDto newcustomerDto)
        {
            //throw new NotImplementedException();

            var customer = new Customer("mazin", "babo");
            //var db = new EcommerceContext();
            //var newCustomer = db.Customers.Add(customer);
            //return Mapping.Mapper.Map<CustomerDto>(newCustomer.Entity);
            return new CustomerDto();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetCustomer(int customerId, bool includeOrders = false)
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetCustomer(string email, bool includeRoles = false, bool includeTenant = false, bool includePaymentMethods = false, bool includeAddress = false)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDto> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public CustomerDto UpdateCustomer(UpdateCustomerDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
