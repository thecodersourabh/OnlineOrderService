using Microsoft.AspNetCore.Mvc;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrderService.Data;
using System.Linq;

namespace OnlineOrderService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MenuItemsController : Controller
    {
        private readonly IMenuItems _menuItems;
       
        public MenuItemsController(IMenuItems menuItems)
        {
            _menuItems = menuItems;
        }

        // GET: MenuItems
        [HttpGet]
        public IActionResult GetMenuItems()
        {
            return Ok(_menuItems.GetMenuItems());
        }

        // GET: MenuItems/Details/5
        [HttpGet]
        public IActionResult GetMenuItemsDetailsByMenuId(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuItem = _menuItems.GetMenuItems()
                .FirstOrDefault(m => m.ItemId == id);
            if (menuItem == null)
            {
                return NotFound();
            }

            return Ok(menuItem);
        }

        
    }
}
