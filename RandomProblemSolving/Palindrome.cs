/*using RandomProblemSolving;
using System;

while (true)
{
    Console.Write("Type a word: ");
    string str = Console.ReadLine();
    if (!string.IsNullOrEmpty(str))
    {
        Palindrome instence = new Palindrome();
        Console.WriteLine(instence.CheckPalindrome(str));
    }
    else
    {
        Console.WriteLine("No input has given, Please try again running the application!");
        break;
    }
}*/
using System;

namespace RandomProblemSolving
{
    public class Palindrome
    {
        public bool CheckPalindrome(string str)
        {
            //char[] strChar = str.ToCharArray();
            //Array.Reverse(strChar);
            //string strReverse = new string(strChar);
            string strReverse = string.Empty;
            bool isPalindrome = false;

            for (int i = str.Length; i > 0; i--)
            {
                strReverse += str[i - 1];
            }

            Console.WriteLine("str: " + str);
            Console.WriteLine("strReverse: " + strReverse);

            if (str == strReverse)
            {
                isPalindrome = true;
            }
            return (isPalindrome);
        }
    }
}