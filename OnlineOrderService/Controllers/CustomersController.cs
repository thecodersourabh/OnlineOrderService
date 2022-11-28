using Microsoft.AspNetCore.Mvc;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrderService.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService customerService)
        {
            _service = customerService;
        }

        // GET: Customers
        public IActionResult Index()
        {
            return Ok(_service.GetAll());
        }

        // GET: Customers/Details/5
        public IActionResult Details(string id)
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

        // GET: Customers/Create
        public IActionResult Create()
        {
            return Ok();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("CustomerId,MobileNumber,Address,EmailId,OtherDetails")] Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(customer);
        //        await _context.SaveChangesAsync();
        //        return Ok(nameof(Index));
        //    }
        //    return Ok(customer);
        //}

        //// GET: Customers/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customer.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(customer);
        //}

     
     
    }
}
