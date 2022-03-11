using System;
using System.Collections.Generic;
using ConsoleMenues.Views;
using ProductCore;
using ProductCore.Services;
using VendingMachine.Interface;

namespace VendingMachine.Data
{
    public class VendingMachineService: IVending
    {
        ProductUtils productUtils = new ProductUtils();
        Menues menues = new Menues();
        Till VendingMachineChangePool = new Till(new int[]{50,50,50,50,50,50,50,50,50});
        Till moneyPool= new Till();

        public Product Purchase()
        {
            int productIndex= menues.PurchaseMenue(productUtils.ShowAll());
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
            int saldo =moneyPool.GetSaldo();
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
