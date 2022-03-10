using System;
using System.Collections.Generic;
using System.Text;
using ProductCore;

namespace VendingMachine.Interface
{
    public interface IVending
    {
        public Product Purchase();
        public List<string> ShowAll();
        public String Details(Product product);
        public void InsertMoney();
        public int EndTransaction();
    }
}
