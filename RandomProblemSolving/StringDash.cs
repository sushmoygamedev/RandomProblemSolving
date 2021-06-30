/*TRIGGER*/
/*
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    StringDash instence = new StringDash();
    instence.Dash(num);
}
catch (Exception)
{
    Console.WriteLine("Can not convert string to int");
} 
*/

using System;

namespace RandomProblemSolving
{
    public class StringDash
    {
        public void Dash(int num)
        {
            string dash = "";

            for (int i = 0; i < num; i++)
            {
                dash += "-";
                Console.WriteLine(dash);
            }
        }
    }
}
