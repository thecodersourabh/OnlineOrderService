using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrder.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string OtherDetails { get; set; }

    }
}
