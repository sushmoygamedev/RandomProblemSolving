using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1030 1";
            bool isValid = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length == 5 && str[i] != ' ' && char.IsDigit(str[i]))
                {
                    isValid = true;
                }
            }

            Console.WriteLine("Zip Code: " + str);
            Console.WriteLine("Zip Code Length: " + str.Length);
            Console.WriteLine("Valid?: " + isValid);
        }
    }
}