using BandMerchShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandMerchShop.Domain.Interfaces
{
    public interface IItemRepository
    { 
    int AddItem(Item item);
    void DeleteItem(int itemId);
    int AddItemType(ItemType itemType);
    void DeleteItemType(int itemTypeId);
    int AddBand(Band band);
    void DeleteBand(int bandId);
    IQueryable<Item> GetItemsByTypeId(int itemTypeId);
    Item GetItemById(int itemId);
    IQueryable<ItemType> GetAllItemTypes();
    }
}



