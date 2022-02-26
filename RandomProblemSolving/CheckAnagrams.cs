#region Test Case
/*while (true)
{
    Console.Write("Insert First String: ");
    string str1 = Console.ReadLine().ToLower();
    Console.Write("Insert Second String: ");
    string str2 = Console.ReadLine().ToLower();
    if (!string.IsNullOrEmpty(str1) || !string.IsNullOrEmpty(str2))
    {
        Console.WriteLine("Result: ");
        Console.WriteLine(CheckAnagrams.IsAnagram(str1, str2));
    }
    else
    {
        Console.WriteLine("Input Missing!!!");
        break;
    }
}*/
#endregion
using System;

namespace RandomProblemSolving
{
    public static class CheckAnagrams
    {
        public static string SimpleSortingFunc(string str)
        {
            char[] strChar = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                strChar[i] = str[i];
                Console.Write(strChar[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < strChar.Length - 1; i++)
            {
                if (strChar[i] > strChar[i + 1])
                {
                    char c = strChar[i];
                    strChar[i] = strChar[i + 1];
                    strChar[i + 1] = c;
                    i = -1;
                }
            }
            string sortedStr = new string(strChar);
            return (sortedStr);
        }
        public static bool IsAnagram(string str1, string str2)
        {
            string sortedString1 = SimpleSortingFunc(str1);
            Console.WriteLine(sortedString1);
            #region Sorting String Backup
            // Simple Sorting Algorithm
            /*char[] str1Char = new char[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                str1Char[i] = str1[i];
                Console.Write(str1Char[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < str1Char.Length-1; i++)
            {
                if (str1Char[i] > str1Char[i+1])
                {
                    char c = str1Char[i];
                    str1Char[i] = str1Char[i + 1];
                    str1Char[i + 1] = c;
                    i = -1;
                }
            }
            string sortedStr1 = new string(str1Char);
            Console.WriteLine(sortedStr1);*/

            // Built-In Sorting Function
            /*char[] str1Char = str1.ToCharArray();
            Array.Sort(str1Char);
            foreach (char c in str1Char)
            {
                Console.Write(c);
            }*/
            #endregion
            string sortedString2 = SimpleSortingFunc(str2);
            Console.WriteLine(sortedString2);
            #region Sorting String Backup
            /*char[] str2Char = str2.ToCharArray();
            Array.Sort(str2Char);
            foreach (char c in str2Char)
            {
                Console.Write(c);
            }*/
            #endregion

            bool isAnagrams = false;
            for (int i = 0; i < sortedString1.Length; i++)
            {
                if (sortedString1[i] == sortedString2[i])
                {
                    isAnagrams = true;

                }
                else
                {
                    isAnagrams = false;
                    break;
                }

            }
            return (isAnagrams);
        }
    }
}