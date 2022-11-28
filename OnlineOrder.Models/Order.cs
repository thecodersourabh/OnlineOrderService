using System;
using System.Collections.Generic;

namespace OnlineOrder.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public int Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string ItemId { get; set; }
        public string CustomerId { get; set; }

    }

   
}
