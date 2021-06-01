using e_commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Application.Services
{
    public interface ICustomerService
    {
        List<CustomerDto> GetCustomers();

        CustomerDto GetCustomer(int customerId, bool includeOrders = false);

        CustomerDto GetCustomer(string email, bool includeRoles = false, bool includeTenant = false, bool includePaymentMethods = false, bool includeAddress = false);

        CustomerDto CreateCustomer(NewCustomerDto newcustomerDto);

        CustomerDto UpdateCustomer(UpdateCustomerDto updateUserDto);

        void DeleteCustomer(int customerId);
    }
}
