using Microsoft.AspNetCore.Mvc;
using OnlineOrder.BusinessServices.Interfaces;
using System.Linq;

namespace OnlineOrderService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IngredientsController : Controller
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        // GET: Ingredients
        [HttpGet]
        public IActionResult GetAllIngredients()
        {
            return Ok(_ingredientService.GetAllIngredients());
        }

        // GET: Ingredients/Details/Extra toppings
        [HttpGet]
        public IActionResult GetAllIngredientsDetailsByName(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var ingredients =  _ingredientService.GetAllIngredients()
                .FirstOrDefault(m => m.IngredientsName == name);
            if (ingredients == null)
            {
                return NotFound();
            }

            return Ok(ingredients);
        }

    }

    
}
