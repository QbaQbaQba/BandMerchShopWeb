using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BandMerchShop.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }
        public int BandId { get; set; }
        public Band Band { get; set; }
        public virtual ICollection<ItemOrder> ItemOrders { get; set; }
    }
}
