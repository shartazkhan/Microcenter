using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class InvoiceService
    {
        InvoiceDataAccess invoiceDataAccess;

        public InvoiceService()
        {
            this.invoiceDataAccess = new InvoiceDataAccess();
        }

        public List<Invoice> GetInvoices()
        {

            return this.invoiceDataAccess.GetInvoices();
        }

        public int AddInvoicesRecord(int invoiceID, string productIName, int quantity, decimal price, decimal discount)
        {
            this.invoiceDataAccess = new InvoiceDataAccess();

            Invoice invoice = new Invoice() { InvoiceID = invoiceID, ProductName = productIName, Quantity = quantity, Price = price, Discount = discount};

            return this.invoiceDataAccess.AddInvoicesRecord(invoice);
        }

        public int DeleteInvoicesRecord(int invoiceID)
        {
            return this.invoiceDataAccess.DeleteInvoicesRecord(invoiceID);

        }
    }
}
