using Ecommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IAddressService
    {
        Task<List<AddressDto>> GetAddresses();

        Task<AddressDto> GetAddress(int addressId);

        Task<AddressDto> CreateAddress(NewAddressDto newAddressDto);

        void DeleteAddress(int addressId);
    }
}
