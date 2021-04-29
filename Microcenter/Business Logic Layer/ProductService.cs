﻿using System;
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

        public int AddNewProduct(string productName, int stock, double retailPrice, double listingPrice, int unit, string categoryName)
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
                CategoryID = categoryId
     
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
    }
}
