using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OnlineShop.Utility
{
    [DebuggerDisplay("نام محصول : {ProductName},گروه : {Category},تعداد : {Quantity}.")]
    public class Product
    {
        static int nextid = 1;
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public Product()
        {
            Id = nextid++;
        }
        public Product(string productName,int quantity,string categoryName,bool isAvailable)
        {
            ProductName = productName;
            Quantity = quantity;
            IsAvailable =isAvailable;
            CategoryName = categoryName;
        }
    }
    
}
