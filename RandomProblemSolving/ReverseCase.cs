// TRIGGER
/*
 string str = "eXCELLENT, yOuR mAJESTY";
            ReverseCase.ReverseChar(str);
            string str2 = "sPoNtAnEoUs";
            ReverseCase.ReverseChar(str2);
 */
using System;

namespace RandomProblemSolving
{
    public class ReverseCase
    {
        public static void ReverseChar(string str)
        {
            string revCase = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    revCase += char.ToLower(str[i]);
                }
                else
                {
                    revCase += char.ToUpper(str[i]);
                }
            }

            Console.WriteLine("Input String: " + str);
            Console.WriteLine("Reverse Case: " + revCase);
        }
    }
}