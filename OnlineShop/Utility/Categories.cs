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
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Categories()
        { }

        public Categories(string name)
        {
            CategoryName = name;
        }
    }
}
