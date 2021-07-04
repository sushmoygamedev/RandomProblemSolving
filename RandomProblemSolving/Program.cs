using System;
namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "benefit";

            /*Console.WriteLine(str.Substring(1, str.Length - 2));*/
            /*for (int i = 1; i < str.Length-1; i++)
            {
                Console.Write(str[i]-1);
            }*/
            for (int i = 1; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}