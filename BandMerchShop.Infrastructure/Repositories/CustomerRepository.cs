using BandMerchShop.Domain.Interfaces;
using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandMerchShop.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;
        public CustomerRepository(Context context)
        {
            _context = context;
        }
        public int AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }
        public void DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        public int AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address.Id;
        }
        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.FirstOrDefault(a => a.Id == addressId);
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }
        public Customer GetCustomerById(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            return customer;
        }

    }
}
