using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System.Collections.Generic;

namespace OnlineOrder.BusinessServices
{
    public class MenuItems : IMenuItems
    {
        public List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>();
        }
    }
}
