using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What do you want?");
            string want = Console.ReadLine();

            Console.WriteLine("Welcome {0} and You want {1}", name, want);
        }
    }
}