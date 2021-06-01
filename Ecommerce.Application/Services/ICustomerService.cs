using e_commerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Application.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerDto>> GetCustomers();

        Task<CustomerDto> GetCustomer(int customerId, bool includeOrders = false);
        Task<CustomerDto> CreateCustomer(NewCustomerDto newcustomerDto);
        Task<CustomerDto> UpdateCustomer(UpdateCustomerDto updateUserDto);

        void DeleteCustomer(int customerId);
    }
}
