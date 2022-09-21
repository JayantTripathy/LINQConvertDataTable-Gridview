using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQConvertDataTable_Gridview.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}