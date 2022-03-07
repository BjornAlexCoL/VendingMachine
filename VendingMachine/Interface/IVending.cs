using System;
using System.Collections.Generic;
using System.Text;
using ProductCore;

namespace VendingMachine.Interface
{
    interface IVending
    {
        Product Purchase();
        List<string> ShowAll();
        String Details(Product product);
        void InsertMoney();
        int EndTransaction();
    }
}
