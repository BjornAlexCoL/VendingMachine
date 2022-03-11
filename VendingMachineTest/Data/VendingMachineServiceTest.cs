using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Data;
using Xunit;

namespace VendingMachineTest.Data
{
    public class VendingMachineServiceTest
    {
        VendingMachineService vendingMachineService = new VendingMachineService();
        [Fact]
        public void PurchaseTest()
        {
            vendingMachineService.Purchase();
        }

        [Fact]
        public void InsertMoneyTest()
        {
            vendingMachineService.InsertMoney();
        }
    }
}
