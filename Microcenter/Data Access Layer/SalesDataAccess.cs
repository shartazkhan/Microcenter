using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class SalesDataAccess : DataAccess
    {
        public List<Sale> GetSales()
        {
            string sql = "SELECT * FROM Sales";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();

                sale.SaleID = Convert.ToInt32(reader["SaleID"]);
                sale.SaleDate = reader["SaleDate"].ToString();
                sale.CategoryName = reader["CategoryName"].ToString();
                sale.ProductName = reader["ProductName"].ToString();
                sale.Unit = Convert.ToInt32(reader["Unit"]);
                sale.Price = Convert.ToDecimal(reader["Price"]);
                sale.Discount = Convert.ToDecimal(reader["Discount"]);
                sales.Add(sale);
            }
            return sales;
        }

        public int GetInvoiceID()
        {
            string sql = "SELECT MAX(InvoiceID) as InvoiceID FROM Sales";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["InvoiceID"]);
            }
            return -1;
        }

        public int AddSalesRecord(Sale sale)
        {
            string sql = "INSERT INTO Sales(InvoiceID,SaleDate,CategoryName,ProductName,Unit,Price,Discount,SalesmanID) VALUES(" + sale.InvoiceID + ",'" + sale.SaleDate + "','" + sale.CategoryName + "','" + sale.ProductName + "'," + sale.Unit + "," + sale.Price + "," + sale.Discount + ", " + sale.SalesmanID + ")";
            return this.ExecuteQuery(sql);
        }

        public int DeleteSalesRecord(int invoiceID, string productName)
        {
            string sql = "DELETE FROM Sales WHERE InvoiceID=" + invoiceID + " AND ProductName='" + productName + "'";
            return this.ExecuteQuery(sql);
        }
    }
}
