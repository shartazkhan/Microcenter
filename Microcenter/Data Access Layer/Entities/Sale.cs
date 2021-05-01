using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcenter.Data_Access_Layer.Entities
{
    class Sale
    {
        public int SaleID { get; set; }
        public string SaleDate { get; set; }
        public int CategoryID { get; set; }
        public int ProductID { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
