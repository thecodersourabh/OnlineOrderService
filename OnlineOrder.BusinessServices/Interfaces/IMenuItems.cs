using System.Collections.Generic;
using OnlineOrder.Models;

namespace OnlineOrder.BusinessServices.Interfaces
{
    public interface IMenuItems
    {
        List<MenuItem> GetMenuItems();
    }
}
