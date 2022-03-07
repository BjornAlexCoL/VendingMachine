using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Till //Take care about the Till
    {

        private static int[] denotations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 }; //valid denotations
        private int[] change = new int[8]; //Current amount of notes and coins in till


        public int Increase(int index) //Add one coin or note to the till
        {
            return ++change[index];
        }
        public int Decrease(int index) //witdraw one coin or note to the till if there is any left otherwise 0.
        {
            return (((change[index]--)>=1)?1 : 0);
        }

        public int GetSaldo() //Return the till saldo
        {
            return GetSaldoFromArray(change);
        }        
 
        private int GetSaldoFromArray(int[] tillArray) //Return Saldo from any array of coins and notes. 
        {
            int saldo = 0;
            foreach (int denotation in denotations)
            {
                saldo += denotations[denotation] * tillArray[denotation];
            }
            return saldo;
        }
        public int[] withDraw(int sum)
        {
            if (sum > GetSaldo()) return null;
            int[] payOut = new int[8];
            for (int index = 7; index >= 0; index--)
            {
                if (sum >= denotations[index])
                {
                    for (int giveBack = (sum % denotations[index]); giveBack > 0; giveBack--)
                    {
                        sum -= (Decrease(index) > 0) ? denotations[index] : 0;
                    }
                    
                                    
                 
                }
            }
            return payOut;
        }
        public int refillChange(int[] newChange)
        {
            if (newChange.Length > 8) return 0;
            for (int index = 0; index <= 7; index++)
            {
                change[index] += newChange[index];
            }
            return GetSaldoFromArray(newChange);
        }
    }
}
