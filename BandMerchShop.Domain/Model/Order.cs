using System;
using System.Collections.Generic;
using System.Text;

namespace BandMerchShop.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
