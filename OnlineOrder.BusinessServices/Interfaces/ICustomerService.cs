using System.Collections.Generic;
using OnlineOrder.Models;

namespace OnlineOrder.BusinessServices.Interfaces
{
    public interface ICustomerService
    {
        public List<Customer> GetAll(); 
    }
}