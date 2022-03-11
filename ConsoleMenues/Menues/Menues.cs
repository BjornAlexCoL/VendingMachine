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

        public void ShowSaldo(List<String> menueItems, int saldo)
        {
            foreach (string menueItem in menueItems)
            {
                Console.WriteLine(menueItem);
            }
            GetValidMenueChoice(1, $"Your total deposit is {saldo}kr. Press 0 to exit! : ");

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
        public int MainMenue(List<string> menueItems) //Main Menue
        {

            return ViewMenue(menueItems, "Main Menue");

        }

        public int ServiceMenue(List<string> menueItems)
        {
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
                menueChoice = GetValidMenueChoice(menueItems.Count, $"Please select 1 to {menueItems.Count} from the menue. 0 to end! : ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No items in menue");
            }
            return menueChoice;
        }

        private int GetValidMenueChoice(int maxMenueItems, string message)
        {
            int number = 0;
            bool validInt;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(message);
                Console.ForegroundColor = ConsoleColor.DarkGreen;


                try
                {
                    string inputValue = Console.ReadLine();
                    number = int.Parse(inputValue ?? "");
                    validInt = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("That choice is not in the menue! Try again;");
                    validInt = false;
                    number = 0;
                }//catch end
                if (number < 0 || number > maxMenueItems)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("That choice is not in the menue! Try again;");
                    validInt = false;
                }
            }
            while (!validInt);
            return number;
        }

        public bool EndSession(List<string> menueItems, int returnMoney)
        {
            bool reallyEnd = false;
            ShowSaldo(menueItems, returnMoney);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Your remaining deposits {returnMoney} vill be returned to you if you leave.");
            if (GetValidMenueChoice(1, "Enter 0 to leave or 1 to stay!") == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Thanks for Using Vendor machine velcome back!");
                reallyEnd = true;
            }
            return reallyEnd;
        }

    }
}
