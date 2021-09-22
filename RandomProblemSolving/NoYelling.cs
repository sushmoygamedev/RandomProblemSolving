// TRIGGER
/*Console.WriteLine("Yell at something with the ending punctuation question marks (?) or exclamation marks (!) more than one:");
string str = Console.ReadLine();

NoYelling instance = new NoYelling();
Console.WriteLine(instance.Yelling(str));*/
using System;

namespace RandomProblemSolving
{
    public class NoYelling
    {
        public string Yelling(string str)
        {
            string newStr = str.Trim(str[str.Length - 1]);

            Console.WriteLine();

            Console.Write("Result with no yelling: ");
            return (newStr + str[str.Length - 1]);
        }
    }
}