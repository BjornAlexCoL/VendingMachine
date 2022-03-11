﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Till //Take care about the Till
    {

        private static int[] denotations = new int[] { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 }; //valid denotations
        private int[] change = new int[denotations.Length]; //Current amount of notes and coins in till

        public Till() { }
        public Till(int[] startChange)
        {
            RefillChange(startChange);
        }

        public int Increase(int index) //Add one coin or note to the till
        {
            ++change[index];
            return 1;
        }
        public int Decrease(int index) //witdraw one coin or note to the till if there is any left otherwise 0.
        {
            return (((change[index]--) >= 1) ? 1 : 0);
        }

        public int GetSaldo() //Return the till saldo
        {
            return GetSaldoFromArray(change);
        }

        public int GetSaldoFromArray(int[] tillArray) //Return Saldo from any array of coins and notes. 
        {
            int saldo = 0;
            for (int index = 0; (index < tillArray.Length) && (index < denotations.Length); index++)
            {
                saldo += denotations[index] * tillArray[index];
            }
            return saldo;
        }
        public int[] Withdraw(int sum) //Withdraw array of coins and notes.
        {
            if (sum > GetSaldo()) return null;
            int[] payOut = new int[denotations.Length];
            for (int index = denotations.Length - 1; index >= 0; index--)
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
        public int RefillChange(int[] newChange) //Add coins and notes.
        {
            if (newChange.Length > denotations.Length) Array.Resize<int>(ref newChange, denotations.Length);//If list of changes is bigger then denotations truncate it.
            for (int index = 0; ((index < denotations.Length) && (index < newChange.Length)); index++)
            {
                change[index] += newChange[index];
            }
            return GetSaldoFromArray(newChange);
        }
        public List<string> ShowDenotations()
        {
            List<string> showDenotations = new List<string>();
            for (int index = 0; index < denotations.Length; index++)
            {
                showDenotations.Add($"{(index + 1)}. {denotations[index]}kr ({change[index]})");
            }

            return showDenotations;
        }
        public List<string> ShowSaldo()
        {
            List<string> showDenotations = new List<string>();
            for (int index = 0; index < denotations.Length; index++)
            {
                showDenotations.Add($"{denotations[index]}kr {change[index]}({change[index] * denotations[index]})");
            }
            return showDenotations;
        }
        public void Flush()
        {
            for (int index = 0; index < change.Length; change[index++] = 0) ;
            
        }
    }
}
