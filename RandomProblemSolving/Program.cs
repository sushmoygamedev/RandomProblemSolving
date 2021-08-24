using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "%fd76$fd(-)6GvKlO.";
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]) || str[i] == ' ' || str[i] == '-' || str[i] == '_')
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);*/

            string str = "-123) 456-7890";
            bool isValid = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' && str[i] == ')' || str[i] == '-')
                {
                    isValid = true;
                }
            }
            Console.WriteLine(isValid);
        }
    }
}