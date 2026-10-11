using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prac6_dnt.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }
    }
}