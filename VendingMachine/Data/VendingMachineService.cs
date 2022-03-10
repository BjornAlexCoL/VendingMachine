using System;
using System.Collections.Generic;
using System.Text;
using ConsoleMenues.Views;
using ProductCore;
using ProductCore.Services;
using VendingMachine.Interface;

namespace VendingMachine.Data
{
    public class VendingMachineService: IVending
    {
        ProductUtils productUtils = new ProductUtils();
        ViewMenues views = new ViewMenues();
        Till VendingMachineChangePool = new Till(new int[]{50,50,50,50,50,50,50,50,50});
        Till moneyPool= new Till();
        
        public Product Purchase()
        {
            int productIndex= views.ViewPurchaseMenue(productUtils.ShowAll());
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
            throw new NotImplementedException();
        }

        public int EndTransaction()
        {
            throw new NotImplementedException();
        }

     }
}
