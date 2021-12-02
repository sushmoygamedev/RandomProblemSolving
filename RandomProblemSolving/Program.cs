using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcd";

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[0]);
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(str[i]);
                }
            }

        }
    }
}