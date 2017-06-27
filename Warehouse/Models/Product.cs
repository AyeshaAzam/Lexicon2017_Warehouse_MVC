using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class Product
    {
        // in Model class we shouldnot have more than only properties/en class som ska ha bara egenskaper

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } 
        public int Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

    }
}