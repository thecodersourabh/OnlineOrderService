using System;
using System.Collections.Generic;
using System.Text;
using OnlineOrder.BusinessServices.Interfaces;
using OnlineOrder.Models;

namespace OnlineOrder.BusinessServices
{
    public class IngredientService : IIngredientService
    {
        public List<Ingredients> GetAllIngredients()
        {
            var ingredients = new List<Ingredients>();
            ingredients.Add(new Ingredients() { IngredientsId = "123", IngredientsName = "Extra Toppings", Cost = "100", ItemId = "101" });
            return ingredients;
        }
    }
}
