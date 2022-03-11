using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenues
{
    interface IMenues
    {
        public int PurchaseMenue(List<String> menueItems);
        public int InsertMoneyMenue(List<String> menueItems);
        public int ShowProductsMenue(List<String> menueItems);
        public int MainMenue();

        public int ServiceMenue();
    }
}
