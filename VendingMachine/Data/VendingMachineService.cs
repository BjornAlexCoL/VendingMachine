using System;
using System.Collections.Generic;
using System.Text;
using ProductCore;
using VendingMachine.Interface;

namespace VendingMachine.Data
{
    class VendingMachineService: IVending
    {
        List<Product> products = new List<Product>();
        Till moneyPool= new Till();
        Product IVending.Purchase()
        {
            throw new NotImplementedException();
        }

        List<string> IVending.ShowAll()
        {
            throw new NotImplementedException();
        }

        string IVending.Details(Product product)
        {
            throw new NotImplementedException();
        }

        void IVending.InsertMoney()
        {
            throw new NotImplementedException();
        }

        int IVending.EndTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
