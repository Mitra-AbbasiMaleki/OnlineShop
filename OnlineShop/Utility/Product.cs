using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Utility
{
    public class Product
    {
        int nextid = 1;
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Categories Category { get; set; }
        public bool IsAvailable { get; set; }
        public Product()
        {
            Id = nextid++;
        }
        public Product(string productName,int quantity,Categories category,bool? isAvailable=null)
        {
            ProductName = productName;
            Quantity = quantity;
            IsAvailable = isAvailable??=true;
            Category = category;
        }
    }
    
}
