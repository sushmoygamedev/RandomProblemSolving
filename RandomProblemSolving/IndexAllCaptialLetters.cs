//TRIGGER
/*
 string str = "deTeRMine";
            Console.WriteLine(IndexAllCaptialLetters.IndexCapital(str));
            string str2 = "TesTCasE";
            Console.WriteLine(IndexAllCaptialLetters.IndexCapital(str2));*/
using System;

namespace RandomProblemSolving
{
    public class IndexAllCaptialLetters
    {
        public static string IndexCapital(string str)
        {
            int[] upperIndex = new int[str.Length];
            int j = 0;
            string allIndex = string.Empty;

            Console.WriteLine("String Length: " + str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    upperIndex[j] = i;
                    j++;
                }
            }

            for (int i = 0; i < j; i++)
            {
                if (i == j - 1)
                {
                    allIndex += (upperIndex[i]);
                }
                else
                {
                    allIndex += (upperIndex[i] + ", ");
                }
            }

            return ("[" + allIndex + "]");
        }
    }
}