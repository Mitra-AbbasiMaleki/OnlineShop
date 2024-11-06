using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Utility
{
    
   public class Categories
    {
        int nextid = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories(string name)
        {
            Id = nextid++;
            Name = name;
        }
    }
}
