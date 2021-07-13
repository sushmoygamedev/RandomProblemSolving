/*TRIGGER*/
/*
 * string str = "something";
 * RemoveFirstLast.FirstLast(str);*/
using System;

namespace RandomProblemSolving
{
    public class RemoveFirstLas
    {
        public static void FirstLast(string[] str)
        {
            string newStr = "";
            //Console.WriteLine(str.Substring(1, str.Length - 2));
            if (str.Length > 2)
            {
                for (int i = 1; i < str.Length - 1; i++)
                {
                    newStr += str[i];

                }
                Console.WriteLine(newStr);
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}