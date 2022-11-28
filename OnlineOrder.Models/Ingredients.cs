using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrder.Models
{
    public class Ingredients
    {
        public int IngredientsId { get; set; }
        public string IngredientsName { get; set; }
        public string PreferenceLevel { get; set; }
        public string ItemId { get; set; }
        public string Cost { get; set; }

    }
}
