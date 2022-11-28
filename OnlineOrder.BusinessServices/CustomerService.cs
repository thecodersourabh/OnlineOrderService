using System;
using System.Collections.Generic;
using System.Text;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using OrderServiceRepository.Interface;

namespace OnlineOrder.BusinessServices
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _repository;

        public CustomerService(ICustomerRepo repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAll()
        {
            var customer = new Customer() { CustomerId = Guid.NewGuid().ToString(), EmailId = "abc@morgen.com" };
            var customer1 = new Customer() { CustomerId = "12", EmailId = "abc12@morgen.com" };
            var customer2 = new Customer() { CustomerId = "13", EmailId = "abc13@morgen.com" };
            return new List<Customer>() { customer, customer1, customer2 };
        }
    }
}
