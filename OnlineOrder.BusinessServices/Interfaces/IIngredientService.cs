using System;
using System.Collections.Generic;
using System.Text;
using OnlineOrder.Models;

namespace OnlineOrder.BusinessServices.Interfaces
{
    public interface IIngredientService
    {
        List<Ingredients> GetAllIngredients();
    }
}
