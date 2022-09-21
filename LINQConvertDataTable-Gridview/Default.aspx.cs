using LINQConvertDataTable_Gridview.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQConvertDataTable_Gridview
{
    public partial class Default : System.Web.UI.Page
    {
        Utility _util = new Utility();
        protected void Page_Load(object sender, EventArgs e)
        {
            getCustomers();
        }
        public void getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerId = 1, Name = "John Smith", Age=59, Country = "United States" });
            customers.Add(new Customer { CustomerId = 2, Name = "Aakash Burman", Age = 30, Country = "India" });
            customers.Add(new Customer { CustomerId = 3, Name = "Tim David", Age = 24, Country = "UK" });
            customers.Add(new Customer { CustomerId = 4, Name = "Kadir syed", Age = 36, Country = "Pakistan" });
            customers.Add(new Customer { CustomerId = 4, Name = "Ravi", Age = 34, Country = "India" });

            //Linq query.
            var query = from customer in customers
                        select customer;

            DataTable dt = _util.ConvertLinqToDataTable<Customer>(query);
        }
    }
}