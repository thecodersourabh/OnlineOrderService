using System.Collections.Generic;
using OnlineOrder.Models;

namespace OnlineOrder.BusinessServices.Interfaces
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetAllOrders();
    }
}
