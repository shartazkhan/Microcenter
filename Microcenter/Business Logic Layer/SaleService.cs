using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{

    class SaleService
    {
        SalesDataAccess salesDataAccess;

        public SaleService()
        {
            salesDataAccess = new SalesDataAccess();
        }

        public List<Sale> GetAllSales()
        {

            return this.salesDataAccess.GetSales();
        }

        public int GetInvoiceID()
        {
            return this.salesDataAccess.GetInvoiceID();
        }

        public int AddNewSalesRecord(int invoiceID, string saleDate, string categoryName, string productIName, int unit, decimal price, decimal discount, int salesmanID)
        {
            this.salesDataAccess = new SalesDataAccess();

            Sale sale = new Sale() { InvoiceID = invoiceID, SaleDate = saleDate, CategoryName = categoryName, ProductName = productIName, Unit = unit, Price = price, Discount = discount, SalesmanID = salesmanID };

            return this.salesDataAccess.AddSalesRecord(sale);
        }

        public int DeleteSalesRecord(int invoiceID, string productName)
        {
            return this.salesDataAccess.DeleteSalesRecord(invoiceID, productName);

        }

       

    }
}