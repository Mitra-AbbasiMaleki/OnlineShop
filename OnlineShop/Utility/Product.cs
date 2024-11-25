using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OnlineShop.Utility
{
    [DebuggerDisplay("نام محصول : {ProductName},گروه : {Category},تعداد : {Quantity}.")]
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public Product()
        {

        }
        public Product(string productName, int quantity, int categoryId, bool isAvailable)
        {
            ProductName = productName;
            Quantity = quantity;
            IsAvailable =isAvailable;
            CategoryId = categoryId;
        }
    }
    
}
