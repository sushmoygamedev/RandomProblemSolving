using System;

namespace RandomProblemSolving
{
    public class ValidHexCode
    {
        public static string IsValidHex(string hexCode)
        {
            bool flag = false;

            if (hexCode[0] == '#' && hexCode.Length == 7)
            {
                for (int i = 0; i < hexCode.Length - 1; i++)
                {
                    if (hexCode[i + 1] >= Convert.ToInt32('0') && hexCode[i + 1] <= Convert.ToInt32('9') || hexCode[i + 1] >= 'A' && hexCode[i + 1] <= 'F')
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
            }
            else
            {
                flag = false;
            }

            return ("RESULT: " + flag);
        }
    }
}

/*
 // TEST
string hexCode = "#987543".ToUpper();
            Console.WriteLine(ValidHexCode.IsValidHex(hexCode));
 */