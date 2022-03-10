using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Data;
using Xunit;

namespace VendingMachineTest.Data
{
    public class VendingMachineServiceTest
    {
        [Fact]
        public void PurchaseTest()
        {
            VendingMachineService vendingMachineService = new VendingMachineService();
            vendingMachineService.Purchase();
        }
    }
}
