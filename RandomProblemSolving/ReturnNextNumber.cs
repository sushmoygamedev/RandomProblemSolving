using RandomProblemSolving;
using System;

namespace RandomProblemSolving
{
    public class ReturnNextNumber
    {
        public static void Addition()
        {

            int[] num = new int[10];
            int incr = 1;

            Console.WriteLine("Insert 10 Number:\n");
            for (int i = 0; i < num.Length; i++)
            {
                try
                {
                    Console.Write("Input {0}: ", i + incr);
                    num[i] = Convert.ToInt32(Console.ReadLine()) + incr;
                    if (string.IsNullOrEmpty(Convert.ToString(num[i])))
                    {
                        //Console.WriteLine(true);
                        break;
                    }
                    else
                    {
                        /*Console.WriteLine(false);
                        continue;*/
                        Console.WriteLine("Result {0}: " + num[i], i + incr);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Not an Integer");
                    //throw;
                }
                

                
            }

            /*Console.WriteLine("\nResult:\n");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Result {0}: " + num[i], i + incr);
            }*/
        }

    }
}

/*
// RUN
ReturnNextNumber.Addition();
*/
