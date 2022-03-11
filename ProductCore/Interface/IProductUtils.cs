using System;
using System.Collections.Generic;
using System.Text;
using NutritionCore.Models;

namespace ProductCore.Services
{
    public interface IProductUtils
    {
        //Create
        public Product AddProduct(Product product);
        public Product AddProduct();
        //Read
        public List<Product> FindSoldOut();
        public List<Product> FindStillLeft();
        public Product FindById(int productId);
        public List<Product> GetAll();
        public List<String> ShowAll();
        //Update
        public bool AddUnitsToStock(int productId, int amount);
        public Nutrition AddNutrition(Nutrition nutrition);
        //Delete
        public bool SellProduct(int productId);
        public bool Delete(int productId);
    }
}
