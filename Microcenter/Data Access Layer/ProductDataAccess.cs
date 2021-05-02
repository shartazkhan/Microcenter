using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class ProductDataAccess : DataAccess
    {
        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(reader["ProductID"]);
                product.ProductName = reader["ProductName"].ToString();
                product.Stock = Convert.ToInt32(reader["Stock"]);
                product.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                product.ListingPrice = Convert.ToDouble(reader["ListingPrice"]);
                product.Unit = Convert.ToInt32(reader["Unit"]);
                product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                product.SaleCount = Convert.ToInt32(reader["SaleCount"]);
                products.Add(product);
            }
            return products;
        }
        public Product GetProductsByID(int id)
        {
            string sql = "SELECT * FROM Products WHERE ProductID=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(reader["ProductID"]);
                product.ProductName = reader["ProductName"].ToString();
                product.Stock = Convert.ToInt32(reader["Stock"]);
                product.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                product.ListingPrice = Convert.ToDouble(reader["ListingPrice"]);
                product.Unit = Convert.ToInt32(reader["Unit"]);
                product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                product.SaleCount = Convert.ToInt32(reader["SaleCount"]);
                return product;
            }
            return null;
        }

        public int AddProduct(Product product)
        {
            string sql = "INSERT INTO Products(ProductName,Stock,RetailPrice,ListingPrice,Unit,CategoryID,SaleCount) VALUES('" + product.ProductName + "'," + product.Stock + "," + product.RetailPrice + "," + product.ListingPrice + "," + product.Unit + "," + product.CategoryID + ","+product.SaleCount+")";
            return this.ExecuteQuery(sql);
        }

        public int UpdateProduct(Product product)
        {
            string sql = "UPDATE Products SET ProductName='" + product.ProductName + "',Stock=" + product.Stock + ",RetailPrice=" + product.RetailPrice + ",ListingPrice=" + product.ListingPrice + ",Unit=" + product.Unit + ",CategoryId=" + product.CategoryID + ",SaleCount=" + product.SaleCount + " WHERE ProductId=" + product.ProductID;
            return this.ExecuteQuery(sql);
        }
        public int DeleteProduct(int id)
        {
            string sql = "DELETE FROM Products WHERE ProductID=" + id;
            return this.ExecuteQuery(sql);
        }
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Products WHERE CategoryID=" + categoryId;
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(reader["ProductID"]);
                product.ProductName = reader["ProductName"].ToString();
                product.Stock = Convert.ToInt32(reader["Stock"]);
                product.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                product.ListingPrice = Convert.ToDouble(reader["ListingPrice"]);
                product.Unit = Convert.ToInt32(reader["Unit"]);
                product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                product.SaleCount = Convert.ToInt32(reader["SaleCount"]);
                products.Add(product);
            }
            return products;
        }

        public List<string> GetProductNames()
        {
            string sql = "SELECT ProductName FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<string> productNames = new List<string>();
            while (reader.Read())
            {
                productNames.Add(reader["ProductName"].ToString());
            }
            return productNames;
        }

        public List<string> GetProductNamesbyCategoryName(string cName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int id = categoryDataAccess.GetCategoryId(cName);

            string sql = "SELECT ProductName FROM Products WHERE CategoryID="+id;
            SqlDataReader reader = this.GetData(sql);
            List<string> productNames = new List<string>();
            while (reader.Read())
            {
                productNames.Add(reader["ProductName"].ToString());
            }
            return productNames;
        }

        public decimal GetProductPrice(decimal id)
        {
            string sql = "SELECT RetailPrice FROM Products WHERE ProductID=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["RetailPrice"]);
            }
            return -1;
        }

        public int GetProductID(string productName)
        {
            string sql = "SELECT ProductID FROM Products WHERE ProductName='" +productName+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["ProductID"]);
            }
            return -1;
        }

        public int GetProductCount(string productName)
        {
            string sql = "SELECT SaleCount FROM Products WHERE ProductName='" + productName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["SaleCount"]);
            }
            return -1;
        }

        public int UpdateProductCount(string productName, int count)
        {
            string sql = "UPDATE Products SET SaleCount=" + count + " WHERE ProductName = '" + productName +"'";
            return this.ExecuteQuery(sql);
        }

    }
}
