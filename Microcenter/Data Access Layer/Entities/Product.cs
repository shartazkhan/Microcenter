﻿using System;
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
        public decimal RetailPrice { get; set; }
        public decimal ListingPrice { get; set; }
        public int Unit { get; set; }
        public int CategoryID { get; set; }
        public int SaleCount { get; set; }

    }
}
