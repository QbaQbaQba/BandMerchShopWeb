using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandMerchShop.Domain.Interfaces
{
    public interface IOrderRepository
    {
        int AddOrder(Order order);
        Order GetOrderById(int orderId);
        IQueryable<Item> GetOrderedItems(Order order);
    }
}
