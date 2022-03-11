using System;
using System.Collections.Generic;

namespace ConsoleMenues
{
    public interface IMenues
    {
        public int PurchaseMenue(List<String> menueItems);
        public int InsertMoneyMenue(List<String> menueItems);
        public int ShowProductsMenue(List<String> menueItems);
        public int MainMenue(List<String> menueItems);

        public int ServiceMenue(List<String> menueItems);
        public void ShowSaldo(List<String> menueItems, int returnMoney);

        public bool EndSession(List<String> menueItems, int returnMoney);
    }
}
