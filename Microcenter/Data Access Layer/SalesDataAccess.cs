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
                sale.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                sale.ProductID = Convert.ToInt32(reader["ProductID"]);
                sale.Unit = Convert.ToInt32(reader["Unit"]);
                sale.Price = Convert.ToDecimal(reader["Price"]);
                sale.Discount = Convert.ToDecimal(reader["Discount"]);
                sales.Add(sale);
            }
            return sales;
        }
    }
}
