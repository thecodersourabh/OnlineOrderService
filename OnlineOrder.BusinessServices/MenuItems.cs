using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System.Collections.Generic;

namespace OnlineOrder.BusinessServices
{
    public class MenuItems : IMenuItems
    {
        public List<Item> GetMenuItems()
        {
            var menu1 = new Item() { Cost = "500", ItemType = "Pizza", ItemId = "201", Name = "Cheese Pizza", Size = "Regular" };
            var menu2 = new Item() { Cost = "400", ItemType = "Pizza", ItemId = "202", Name = "Veggie Pizza", Size = "Regular" };
            var menu3 = new Item() { Cost = "300", ItemType = "Pizza", ItemId = "203", Name = "Veggie Pizza", Size = "small" };
            return new List<Item>() { menu1, menu2, menu3 };
        }
    }
}
