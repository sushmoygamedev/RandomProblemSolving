using System;

namespace RandomProblemSolving
{
    public class SmoothSentences
    {
        public static string IsSmooth(string str) 
        {
            string[] strSplit = str.Split(' ');

            bool flag = false;

            for (int i = 0; i < strSplit.Length - 1; i++)
            {
                Console.WriteLine(strSplit[i][strSplit[i].Length - 1] + " == " + strSplit[i + 1][0]);

                if (strSplit[i][strSplit[i].Length - 1] == strSplit[i + 1][0])
                {
                    flag = true;
                    Console.WriteLine(flag);
                }
                else
                {
                    flag = false;
                    Console.WriteLine(flag);
                    break;
                }
            }

            return ("Result: " + flag);
        }
    }
}

/*
 // TEST

string str = "Marta appreciated deep perpendicular right trapezoids".ToLower();
            Console.WriteLine(SmoothSentences.IsSmooth(str));
 */