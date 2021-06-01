using AutoMapper;
using e_commerce.Aggregates.CustomerAgg;
using Ecommerce.Application.Dtos;
using ECommerce.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Ecommerce.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IMapper _mapper;

        public AddressService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<AddressDto> CreateAddress(NewAddressDto newAddressDto)
        {
            var address = new Address(newAddressDto.Country, newAddressDto.City, newAddressDto.PostCode, newAddressDto.LineAddress, newAddressDto.CustomerId);
            var newaddress = await _unitOfWork.Addresses.Insert(address);
            _unitOfWork.Commit();
            return _mapper.Map<AddressDto>(newaddress);
        }

        public void DeleteAddress(int addressId)
        {
            _unitOfWork.Addresses.Delete(addressId);
        }

        public async Task<AddressDto> GetAddress(int addressId)
        {
            var address = await _unitOfWork.Addresses.GetByID(addressId);
            return _mapper.Map<Address, AddressDto>(address);
        }

        public async Task<List<AddressDto>> GetAddresses()
        {
            var addresses = await _unitOfWork.Addresses.Get();
            return _mapper.Map<List<Address>, List<AddressDto>>(addresses.ToList());
        }
    }
}
