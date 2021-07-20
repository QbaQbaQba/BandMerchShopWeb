using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BandMerchShop.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        int AddCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        int AddAddress(Address address);
        void DeleteAddress(int addressId);
        Customer GetCustomerById(int customerId);
    }
}
