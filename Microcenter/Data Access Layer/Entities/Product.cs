using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcenter.Data_Access_Layer.Entities
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double RetailPrice { get; set; }
        public double ListingPrice { get; set; }
        public int Unit { get; set; }
        public int CategoryID { get; set; }

    }
}
