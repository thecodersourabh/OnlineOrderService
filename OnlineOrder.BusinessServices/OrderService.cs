using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System;
using System.Collections.Generic;

namespace OnlineOrder.BusinessServices
{
    public class OrderService : IOrderService
    {
        //private readonly OnlineOrderServiceContext _context;
        public OrderService()
        {
                
        }
        public IEnumerable<Order> GetAllOrders()
        {
            var order1 = new Order() { CustomerId = "12", ItemId = "22", OrderDate = DateTime.Now, OrderId = "101" };
            var order2 = new Order() { CustomerId = "12", ItemId = "22", OrderDate = DateTime.Now, OrderId = "102" };
            var order3 = new Order() { CustomerId = "12", ItemId = "22", OrderDate = DateTime.Now, OrderId = "103" };
            var orders = new List<Order>() { order1, order2, order3 };
            return orders;
        }

        public IEnumerable<Order> CreateOrder(Order order)
        {
           // _context.SaveChangesAsync();
            throw new NotImplementedException();
        }
    }


}
