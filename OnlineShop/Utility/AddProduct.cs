using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Utility
{
    public sealed class AddProduct
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public bool IsAvailable { get; set; }
    }
}
