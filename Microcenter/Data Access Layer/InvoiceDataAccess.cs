using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class InvoiceDataAccess : DataAccess
    {
        public List<Invoice> GetInvoices()
        {
            string sql = "SELECT * FROM Invoices";
            SqlDataReader reader = this.GetData(sql);
            List<Invoice> invoices = new List<Invoice>();
            while (reader.Read())
            {
                Invoice invoice = new Invoice();

                invoice.InvoiceID = Convert.ToInt32(reader["InvoiceID"]);
                invoice.ProductName = reader["ProductName"].ToString();
                invoice.Quantity = Convert.ToInt32(reader["Quantity"]);
                invoice.Discount = Convert.ToDecimal(reader["Discount"]);
                invoice.Price = Convert.ToDecimal(reader["Price"]);

                invoices.Add(invoice);
            }
            return invoices;
        }

        public int AddInvoicesRecord(Invoice invoice)
        {
            string sql = "INSERT INTO Invoices(InvoiceID,ProductName,Quantity,Discount,Price) VALUES(" + invoice.InvoiceID + ",'" + invoice.ProductName + "'," + invoice.Quantity + "," + invoice.Discount + "," + invoice.Price + ")";
            return this.ExecuteQuery(sql);
        }

        public int DeleteInvoicesRecord(int invoiceID)
        {
            string sql = "DELETE FROM Invoices WHERE InvoiceID=" + invoiceID;
            return this.ExecuteQuery(sql);
        }
    }
}
