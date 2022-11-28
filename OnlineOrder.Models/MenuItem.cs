using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrder.Models
{
    public class MenuItem
    {
        public string MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ItemType { get; set; }
        public string Size { get; set; }
        public string Cost { get; set; }

    }
}
