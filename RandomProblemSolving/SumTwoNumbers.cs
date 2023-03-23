using System;

namespace RandomProblemSolving
{
    public class SumTwoNumbers
    {
        public static void Sum()
        {
            try
            {
                Console.Write("Insert a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("a = {0}, b = {1}, sum = {2} \na + b = sum \n{0} + {1} = {2}", a, b, sum);
            }
            catch (Exception)
            {
                Console.WriteLine("Input is not Integer!");
                //throw;
            }
        }
    }
}

/*
 // TRIGGER
SumTwoNumbers.Sum();
 */