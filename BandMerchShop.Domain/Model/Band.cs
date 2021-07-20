using System.Collections.Generic;

namespace BandMerchShop.Domain.Model
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}