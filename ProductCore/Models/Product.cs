using System;
using System.Collections.Generic;
using System.Text;
using NutritionCore.Services;
using ProductCore.Services;

namespace ProductCore
{
    public abstract class Product
    {
        private readonly int id;
 /*     private string caption;
        private double content;
        private string contentUnit;
        string containerType;
        private int stock;
        private int cost;
   */     NutritionUtils nutritions = new NutritionUtils();

        public Product()
        {
            id = ProductSequencer.NextProductId();
        }
        public Product(string caption, double content, string contentUnit, string containerType, int cost, int stock) : this()
        {
            Caption = caption;
            Content = content;
            ContentUnit = contentUnit;
            ContainerType = containerType;
            Stock = stock;
            Cost = cost;
        }
        public string Id { get; }
        public string Caption { get; }
        public double Content { get; set; }
        public string ContentUnit { get; set; }
        public string ContainerType { get; set; }
        public int Stock { get; set; }
        public int Cost { get; set; }

        public abstract string Examine();
        public abstract string Use();

        public string ShowProduct()
        {
            string productInfo = null;
            if (Stock > 0)
                {
                productInfo = $"{id}. {Caption} {Content}{ContentUnit} {ContainerType} {Cost}kr"; 
                }
            return productInfo;
        }
    }


}

