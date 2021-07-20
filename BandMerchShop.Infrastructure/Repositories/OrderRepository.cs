using BandMerchShop.Domain.Interfaces;
using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandMerchShop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Context _context;
        public OrderRepository(Context context)
        {
            _context = context;
        }

        public int AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order.Id;
        }
        public Order GetOrderById(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            return order;
        }
        public IQueryable<Item>GetOrderedItems(Order order)
        {
            var items = order.ItemOrders.Where(io => io.OrderId == order.Id).Select(io => io.Item).AsQueryable();
            return items;
        }

    }
}
