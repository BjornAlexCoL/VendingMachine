using System;
using VendingMachine.Data;
using ConsoleMenues.Views;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Menues menue = new Menues();
            VendingMachineService vendingMachineService = new VendingMachineService();
            int menueChoice = 0;
            do
            {
                menueChoice = menue.MainMenue();
            }
            while (menueChoice != 0);
        }


    }
}
