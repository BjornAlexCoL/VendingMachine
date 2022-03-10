using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenues.Views
{
    public class ViewMenues : IViewMenues
    {
        
        public int ViewInsertMoney(List<string> menueItems) //Show list of Denotations
        {
            return viewMenue(menueItems,"Insert Coin Menue");//Will return 0 for exit decrease result for right index of denotation
        }

        public int ViewPurchaseMenue(List<string> menueItems)
        {
            return viewMenue(menueItems,"Purchase Menue"); 
            
        }

        private int viewMenue ( List<string> menueItems,string headline)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(headline);
            int menueChoice=0;
            if (menueItems!=null)
            {
                foreach (string menueItem in menueItems)
                {
                    Console.WriteLine(menueItem);
                }
            menueChoice=getValidMenueItem(menueItems.Count);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No items in menue");
            }
            return menueChoice;
        }

        private int getValidMenueItem(int maxMenueItem) 
         {  int number=0;
            bool validInt;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Please select 1 to {maxMenueItem} from the menue. 0 to end"  );
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
