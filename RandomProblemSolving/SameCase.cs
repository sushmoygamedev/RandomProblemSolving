/*TRIGGER*/
/*while (true)
{
    Console.Write("Type Word: ");
    string str = Console.ReadLine();
    if (!string.IsNullOrEmpty(str))
    {

        SameCase.IsMixed(str);
    }
    else
    {
        Console.WriteLine("EXIT");
        break;
    }
}*/
using System;

namespace RandomProblemSolving
{
    public class SameCase
    {
        public static void IsMixed(string str)
        {
            bool result = false;
            if (str == str.ToLower() || str == str.ToUpper())
            {
                result = true;
            }
            Console.WriteLine(result);
        }
    }
}