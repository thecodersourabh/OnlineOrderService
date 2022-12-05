using Microsoft.AspNetCore.Mvc;
using OnlineOrder.BusinessServices.Interfaces;
using System.Linq;

namespace OnlineOrderService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService customerService)
        {
            _service = customerService;
        }

        // GET: Customers
        [HttpGet]
        public IActionResult getAllCustomers()
        {
            return Ok(_service.GetAll());
        }

        // GET: Customers/Details/5
        [HttpGet]
        public IActionResult getCustomerDetailsById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _service.GetAll()
                .FirstOrDefault(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

       

    }
}
