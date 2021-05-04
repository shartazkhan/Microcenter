using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class CategoryService
    {
        CategoryDataAccess categoryDataAccess;
        public CategoryService()
        {
            this.categoryDataAccess = new CategoryDataAccess();
        }

        public List<Category> GetAllCategories()
        {
            return this.categoryDataAccess.GetCategories();
        }
        public Category GetCategory(int id)
        {
            return this.categoryDataAccess.GetCategory(id);
        }

        public int AddNewCategory(string categoryName, int count)
        {
            Category category = new Category() { CategoryName = categoryName, SaleCount = count };
            return this.categoryDataAccess.AddCategory(category);
        }
        public int UpdateExistingCategory(int categoryId, string categoryName)
        {
            Category category = new Category() { CategoryID = categoryId, CategoryName = categoryName };
            return this.categoryDataAccess.UpdateCategory(category);
        }
        public int DeleteCategory(int id)
        {
            return this.categoryDataAccess.DeleteCategory(id);

        }
        public List<string> GetCategoryNames()
        {
            return this.categoryDataAccess.GetCategoryNames();
        }

        public int GetCategoryID(string categoryName)
        {
            int id = Convert.ToInt32(this.categoryDataAccess.GetCategoryId(categoryName));
            return id;
        }

        public string GetCategoryName(int id)
        {
            string categoryName = this.categoryDataAccess.GetCategoryNameById(id).ToString();
            return categoryName;
        }

        public int GetCategoryCount(string categoryName)
        {
            return this.categoryDataAccess.GetCategoryCount(categoryName);
        }
        public int UpdateCategoryCount(string categoryName, int count)
        {
            return this.categoryDataAccess.UpdateCategoryCount(categoryName, count);
        }

        public int GetMaxSalesCount()
        {
            return categoryDataAccess.GetMaxSalesCount();
        }

        public string GetBestCategory(int maxSaleCount)
        {
            return categoryDataAccess.GetBestCategory(maxSaleCount);
        }

    }
}
