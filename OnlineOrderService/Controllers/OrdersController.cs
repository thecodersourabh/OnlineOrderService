using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrderService.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _service;
       

        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        // GET: Orders
        public IActionResult Index()
        {
            return Ok(_service.GetAllOrders());
        }

        // GET: Orders/Details/5
        public IActionResult Details(string id)
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
