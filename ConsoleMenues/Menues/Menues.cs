using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenues.Views
{
    public class Menues : IMenues
    {

        public int InsertMoneyMenue(List<string> menueItems) //Show list of Denotations
        {
            return ViewMenue(menueItems, "Insert Coin Menue");//Will return 0 for exit decrease result for right index of denotation
        }

        public int PurchaseMenue(List<string> menueItems)
        {
            return ViewMenue(menueItems, "Purchase Menue");

        }



        public int ShowProductsMenue(List<string> menueItems)
        {
            return ViewMenue(menueItems, "Product Menue");
            ;
        }

        public int MainMenue()
        {
            List<string> menueItems = new List<string>();
            menueItems.Add("Purchase Product.");
            menueItems.Add("Show Products.");
            menueItems.Add("Deposit Coins.");
            menueItems.Add("Service Menue.");
            return ViewMenue(menueItems, "Main Menue");

        }

        public int ServiceMenue()
        {     
            List<string> menueItems = new List<string>();
            menueItems.Add("Add Product.");
            menueItems.Add("Restock Product.");
            menueItems.Add("Refill Change.");
            return ViewMenue(menueItems, "Service Menue");
        }
        private int ViewMenue(List<string> menueItems, string headline)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(headline);
            int menueChoice = 0;
            if (menueItems != null)
            {
                foreach (string menueItem in menueItems)
                {
                    Console.WriteLine(menueItem);
                }
                menueChoice = GetValidMenueChoice(menueItems.Count);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No items in menue");
            }
            return menueChoice;
        }

        private int GetValidMenueChoice(int maxMenueItem)
        {
            int number = 0;
            bool validInt;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Please select 1 to {maxMenueItem} from the menue. 0 to end! : ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;


                try
                {
                    string inputValue = Console.ReadLine();
                    number = int.Parse(inputValue ?? "");
                    validInt = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That choice is not in the menue! Try again;");
                    Console.ResetColor();
                    validInt = false;
                    number = 0;
                }//catch end
            }
            while (!validInt);
            return number;
        }
    }

}
