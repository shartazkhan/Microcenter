using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class CategoryDataAccess : DataAccess
    {
        public List<Category> GetCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                category.CategoryName = reader["CategoryName"].ToString();
                category.SaleCount = Convert.ToInt32(reader["SaleCount"]);
                categories.Add(category);
            }
            return categories;
        }
        public Category GetCategory(int id)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryID=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Category category = new Category();
                category.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                category.CategoryName = reader["CategoryName"].ToString();
                category.SaleCount = Convert.ToInt32(reader["SaleCount"]);
                return category;
            }
            return null;
        }

        public int AddCategory(Category category)
        {
            string sql = "INSERT INTO Categories(CategoryName,SaleCount) VALUES('" + category.CategoryName + "',"+ category.SaleCount+")";
            return this.ExecuteQuery(sql);
        }
        public int UpdateCategory(Category category)
        {
            string sql = "UPDATE Categories SET CategoryName='" + category.CategoryName + "' WHERE CategoryID=" + category.CategoryID;
            return this.ExecuteQuery(sql);
        }
        public int DeleteCategory(int id)
        {
            string sql = "DELETE FROM Categories WHERE CategoryID=" + id;
            return this.ExecuteQuery(sql);
        }

        public int GetCategoryId(string name)
        {
            string sql = "SELECT CategoryID FROM Categories WHERE CategoryName='" + name + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["CategoryID"]);
            }
            return -1;
        }

        public string GetCategoryNameById(int id)
        {
            string sql = "SELECT CategoryName FROM Categories WHERE CategoryID=" + id + "";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["CategoryName"].ToString();
            }
            return null;
        }
        public List<string> GetCategoryNames()
        {
            string sql = "SELECT CategoryName FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<string> categoryNames = new List<string>();
            while (reader.Read())
            {
                categoryNames.Add(reader["CategoryName"].ToString());
            }
            return categoryNames;
        }

        public int GetCategoryCount(string categoryName)
        {
            string sql = "SELECT SaleCount FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["SaleCount"]);
            }
            return -1;
        }

        public int UpdateCategoryCount(string categoryName, int count)
        {
            string sql = "UPDATE Categories SET SaleCount=" + count + " WHERE CategoryName = '" + categoryName + "'";
            return this.ExecuteQuery(sql);
        }

        public int GetMaxSalesCount()
        {
            string sql = "SELECT MAX(SaleCount) as SaleCount FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["SaleCount"]);
            }
            return -1;
        }

        public string GetBestCategory(int maxSaleCount)
        {
            string sql = "SELECT CategoryName FROM Categories WHERE SaleCount=" + maxSaleCount;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["CategoryName"].ToString();
            }
            return null;
        }
    }
}
