using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcenter.Data_Access_Layer.Entities
{
    class Invoice
    {
        public int InvoiceID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
    }
}
