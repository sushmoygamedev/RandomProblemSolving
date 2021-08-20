// TRIGGER
/*string str = "testing";
Console.WriteLine(MiddleCharacterString.MiddleChar(str));*/
using System;

namespace RandomProblemSolving
{
    public class MiddleCharacterString
    {
        public static string MiddleChar(string str)
        {
            int strLen = str.Length;
            string middleChar = string.Empty;

            Console.WriteLine(str.Length / 2);
            Console.WriteLine(strLen % 2);

            if (strLen % 2 != 0)
            {
                middleChar += (str[strLen / 2]);
            }
            else
            {
                middleChar += (str[strLen / 2 - 1] + "" + str[strLen / 2]);
            }

            return middleChar;
        }
    }
}