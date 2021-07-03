/*TRIGGER*/
/*Burrrp.LongBurp(10);*/
using System;

namespace RandomProblemSolving
{
    public class Burrrp
    {
        public static void LongBurp(int num)
        {
            string str = "";
            for (int i = 0; i < num; i++)
            {
                str += "r";
            }

            if (num <= 1)
            {
                Console.WriteLine("Burp");
            }
            else
            {
                Console.WriteLine("Bu" + str + "p");
            }
        }
    }
}