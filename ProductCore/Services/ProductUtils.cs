using System;
using System.Collections.Generic;
using System.Text;
using NutritionCore.Models;

namespace ProductCore.Services
{
    public class ProductUtils : IProductUtils
    {

        List<Product> productList = new List<Product>();
        public ProductUtils() { }
        public ProductUtils(Product[] foundationSupply)
        {
        foreach(Product product in foundationSupply)
            {
                AddProduct(product);
            }
        }

        public Nutrition AddNutrition(Nutrition nutrition)
        {
            throw new NotImplementedException();
        }

        public Product AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public Product AddProduct()
        {
            throw new NotImplementedException();
        }

        public bool AddUnitsToStock(int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int productId)
        {
            if (productId != 0)
            {
                foreach(Product prod in productList)
                {
                    if (prod.Id.Equals(productId))
                    {
                        return prod;
                    }
                }
            }
                return null;
        }

        public List<Product> FindSoldOut()
        {
            throw new NotImplementedException();
        }

        public List<Product> FindStillLeft()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool SellProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public List<string> ShowAll()
        {
            List<String> showProductLista=null;
            string showProduct;
            foreach(Product product in productList)
            {
                showProduct = product.ShowProduct();
                if (showProduct != null)
                {
                    showProductLista.Add(showProduct);
                } 
            }
            return showProductLista;
        }
        
    }
}
