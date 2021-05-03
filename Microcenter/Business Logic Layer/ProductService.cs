using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class ProductService
    {
        ProductDataAccess productDataAccess;
        public ProductService()
        {
            this.productDataAccess = new ProductDataAccess();
        }

        public List<Product> GetAllProducts()
        {
            return this.productDataAccess.GetProducts();
        }
        public Product GetProduct(int id)
        {
            return this.productDataAccess.GetProductsByID(id);
        }

        public int AddNewProduct(string productName, int stock, double retailPrice, double listingPrice, int unit, string categoryName, int count)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);

            Product product = new Product()
            {
                ProductName = productName,
                Stock = stock,
                RetailPrice= retailPrice,
                ListingPrice = listingPrice,
                Unit = unit,
                CategoryID = categoryId,
                SaleCount = count
     
            };
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.AddProduct(product);
        }
        public int UpdateExistingProduct(int productId, string productName, int stock, double retailPrice, double listingPrice, int unit, string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);
            Product product = new Product()
            {
                ProductID = productId,
                ProductName = productName,
                Stock = stock,
                RetailPrice = retailPrice,
                ListingPrice = listingPrice,
                Unit = unit,
                CategoryID = categoryId
            };
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.UpdateProduct(product);
        }
        public int DeleteProduct(int id)
        {
            return this.productDataAccess.DeleteProduct(id);
        }
        public List<Product> GetAllProductsByCategory(string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.GetProductsByCategoryId(categoryId);
        }

        public List<string> GetProductNames()
        {
            return this.productDataAccess.GetProductNames();
        }
        public List<string> GetProductNamesbyCategoryName(string categoryName)
        {
            return this.productDataAccess.GetProductNamesbyCategoryName(categoryName);
        }

        public int GetProductID(string producName)
        {
            return this.productDataAccess.GetProductID(producName);
        }
       

        public decimal GetProductPrice(int producID)
        {
            return this.productDataAccess.GetProductPrice(producID);
        }

        public int GetProductCount(string producName)
        {
            return this.productDataAccess.GetProductCount(producName);
        }
        public int GetProductUnit(string producName)
        {
            return this.productDataAccess.GetProductCount(producName);
        }

        public int UpdateProductCount(string productName, int count)
        {
            return this.productDataAccess.UpdateProductCount(productName,count);
        }
         public int UpdateProductUnit(string productName, int unit)
        {
            return this.productDataAccess.UpdateProductCount(productName,unit);
        }

         public List<string> GetBestProducts(int maxSaleCount)
         {
             return productDataAccess.GetBestProducts(maxSaleCount);
         }
         public string GetBestProduct(int maxSaleCount)
         {
             return productDataAccess.GetBestProduct(maxSaleCount);
         }

         public int GetMaxSalesCount()
         {
             return productDataAccess.GetMaxSalesCount();
         }
    }
}
