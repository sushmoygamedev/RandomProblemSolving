// TRIGGER
/*
 //#1
 string str = "eXCELLENT, yOuR mAJESTY";
            ReverseCase.ReverseChar(str);
            string str2 = "sPoNtAnEoUs";
            ReverseCase.ReverseChar(str2);

#2
string str = "sPoNtAnEoUs";
            ReverseLetterCase.Reverse(str);
            string str2 = "hELLo World";
            ReverseLetterCase.Reverse(str2);
 */
using System;

namespace RandomProblemSolving
{
    public class ReverseCase
    {
        public static void ReverseChar(string str)
        {
            //#1
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

            // #2
            /*int charCount = str.Length;
            string reverseCase = string.Empty;

            for (int i = 0; i < charCount; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    reverseCase += (char.ToLower(str[i]));
                }
                else
                {
                    reverseCase += (char.ToUpper(str[i]));
                }
            }

            Console.WriteLine("Input String: " + str);
            Console.WriteLine("Out String: " + reverseCase);*/
        }
    }
}