using System;
using System.Collections.Generic;
using e_commerce.Application.Dtos;
using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Application.Helpers;
using ECommerce.Data.Interfaces;
using ECommerce.Data.UnitOfWork;
using AutoMapper;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<CustomerDto> CreateCustomer(NewCustomerDto newcustomerDto)
        {
            //throw new NotImplementedException();

            var customer = new Customer(newcustomerDto.FirstName, newcustomerDto.LastName, newcustomerDto.Email);
            var newCustomer = await _unitOfWork.Customers.Insert(customer);
            _unitOfWork.Commit();
            return Mapping.Mapper.Map<CustomerDto>(newCustomer);
        }

        public void DeleteCustomer(int customerId)
        {
            _unitOfWork.Customers.Delete(customerId);
        }

        public async Task<CustomerDto> GetCustomer(int customerId, bool includeOrders = false)
        {
            var customer = await _unitOfWork.Customers.GetByID(customerId);
            return _mapper.Map<Customer, CustomerDto>(customer);
        }


        public async Task<List<CustomerDto>> GetCustomers()
        {
            var customers = await _unitOfWork.Customers.Get();
            return _mapper.Map<List<Customer>, List<CustomerDto>>(customers.ToList());
        }

        public Task<CustomerDto> UpdateCustomer(UpdateCustomerDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
