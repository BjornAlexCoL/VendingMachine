using System;
using VendingMachine.Data;
using ConsoleMenues.Views;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Menues menue = new Menues();
            VendingMachineService vendingMachineService = new VendingMachineService();
            MainMenue(vendingMachineService, menue);
        
        }

        public static void MainMenue(VendingMachineService vendingMachineService, Menues menue)
        {
            List<string> menueItems = new List<string>();
            menueItems.Add("1. Purchase Product.");
            menueItems.Add("2. Show Products.");
            menueItems.Add("3. Deposit Coins.");
            menueItems.Add("4. Service Menue.");
            int menueChoice = 0;
            do
            {
                menueChoice = menue.MainMenue(menueItems);
                switch (menueChoice)
                {
                    case 0:
                        {
                            menueChoice=vendingMachineService.EndTransaction();
                            break;
                        }
                            case 1:
                        {
                            vendingMachineService.Purchase();

                            break;
                        }
                    case 2:
                        {
                            vendingMachineService.ShowAll();
                            break;
                        }
                    case 3:
                        {
                            vendingMachineService.InsertMoney();
                            break;
                        }
                    case 4:
                        {
                            ServiceMenue(vendingMachineService, menue);
                            break;
                        }

                    default:
                        break;
                }
            }
            while (menueChoice != 0);
        }
        public static void ServiceMenue(VendingMachineService vendingMachineService, Menues menue)
        {
            List<string> menueItems = new List<string>();
            menueItems.Add("1. Add Product.");
            menueItems.Add("2. Restock Product.");
            menueItems.Add("3. Refill Change.");
            int menueChoice = 0;
            do
            {
                menueChoice = menue.ServiceMenue(menueItems);
                switch (menueChoice)
                { 
                                       case 1:
                    {
           
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }

                default:
                    break;


                }
            }
            while (menueChoice != 0);
        }
    }
}




