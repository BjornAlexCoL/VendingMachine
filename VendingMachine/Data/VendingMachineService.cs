using System;
using System.Collections.Generic;
using ConsoleMenues.Views;
using ProductCore;
using ProductCore.Models;
using ProductCore.Services;
using VendingMachine.Interface;

namespace VendingMachine.Data
{
    public class VendingMachineService : IVending
    {
        ProductUtils productUtils = new ProductUtils(new Product[]{
            new Beverage("Coca-Cola", 33, "cl", "Can", 10, 20, true),
            new Beverage("Coca-Cola", 50, "cl", "Bottle", 20, 20, true),
            new Beverage("Mer",33,"cl","Bottle",15,20,false),
            new MicrowaveFood("Lasagne",400,"g","Box",35,20,7),
            new Fruit("Orange", "Citrus", "Sinensis",150,"g","Peel",5,20),
            new Beverage("Milk",3,"dl","Tetrapac",7,20,false)});
        Menues menues = new Menues();
        Till VendingMachineChangePool = new Till(new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50 });
        Till moneyPool = new Till();

        public Product Purchase()
        {
            int productIndex = menues.PurchaseMenue(productUtils.ShowAll());
            Product product = productUtils.FindById(productIndex);
            return product;
        }

        public List<string> ShowAll()
        {
            return productUtils.ShowAll();
        }

        public string Details(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertMoney()
        {
            int tillIndex = 0;
            do
            {
                tillIndex = menues.InsertMoneyMenue(moneyPool.ShowDenotations());
                if (tillIndex > 0)
                { moneyPool.Increase(tillIndex - 1); }
            }
            while (tillIndex > 0);
        }

        public int EndTransaction()
        {
            int saldo = moneyPool.GetSaldo();
            if (menues.EndSession(moneyPool.ShowSaldo(), saldo))
            {
                moneyPool.Flush();
                return 0;
            }

            return 1;
        }

        public Product AddProduct()
        {
            return productUtils.AddProduct();
        }
    }
}
