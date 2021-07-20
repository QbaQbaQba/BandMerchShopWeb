using BandMerchShop.Domain.Interfaces;
using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandMerchShop.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }
        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id; 
        }
        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item!=null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }
        public int AddItemType(ItemType itemType)
        {
            _context.ItemTypes.Add(itemType);
            _context.SaveChanges();
            return itemType.Id;
        }
        public void DeleteItemType(int itemTypeId)
        {
            var itemType = _context.ItemTypes.FirstOrDefault(it => it.Id == itemTypeId);
            if(itemType!=null)
            {
                _context.Remove(itemType);
                _context.SaveChanges();
            }
        }
        public int AddBand(Band band)
        {
            _context.Bands.Add(band);
            _context.SaveChanges();
            return band.Id;
        }
        public void DeleteBand(int bandId)
        {
            var band = _context.ItemTypes.FirstOrDefault(b => b.Id == bandId);
            if (band != null)
            {
                _context.Remove(band);
                _context.SaveChanges();
            }
        }
        public IQueryable<Item> GetItemsByTypeId(int itemTypeId)
        {
            var items = _context.Items.Where(i => i.ItemTypeId == itemTypeId);
            return items;
        }
        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }
        public ItemType GetItemTypeById(int itemTypeId)
        {
            var itemType = _context.ItemTypes.FirstOrDefault(it => it.Id == itemTypeId);
            return itemType;
        }
        public IQueryable<ItemType> GetAllItemTypes()
        {
            var itemTypes = _context.ItemTypes;
            return itemTypes;
        }
        
    }
}
