using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System.Linq;

namespace OnlineOrderService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _service;
       

        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        // GET: Orders
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_service.GetAllOrders());
        }

        // GET: Orders/Details/5
        [HttpGet]
        public IActionResult GetOrderDetailsById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _service.GetAllOrders()
                .FirstOrDefault(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpGet]
        public IActionResult GetOrderDetailsByCustomerId(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _service.GetAllOrders()
                .Select(m => m.CustomerId == id);
            if (!order.Any())
            {
                return NotFound();
            }

            return Ok(order);
        }


        // POST: Orders/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("OrderId,Price,OrderDate,ItemId,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _service.CreateOrder(order);
               
                return Ok(nameof(Index));
            }
            return Ok(order);
        }

       
    }
}
