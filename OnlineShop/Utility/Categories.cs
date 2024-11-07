using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OnlineShop.Utility
{
    [DebuggerDisplay("Category : {Name}")]
    public class Categories
    {
        static int nextid = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories(string name)
        {
            Id = nextid++;
            Name = name;
        }
    }
}
