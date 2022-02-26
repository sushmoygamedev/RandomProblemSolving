#region Test Case
/*string phoneNumber = "(33D)ONT-FAIL".ToUpper();
Console.WriteLine(PhoneNumberDecoder.Decode(phoneNumber));*/
#endregion
using System;

namespace RandomProblemSolving
{
    public class PhoneNumberDecoder
    {
        public static string Decode(string phoneNumber)
        {
            string decodedNumber = string.Empty;
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                switch (phoneNumber[i])
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        decodedNumber += '2';
                        break;
                    case 'D':
                    case 'E':
                    case 'F':
                        decodedNumber += '3';
                        break;
                    case 'G':
                    case 'H':
                    case 'I':
                        decodedNumber += '4';
                        break;
                    case 'J':
                    case 'K':
                    case 'L':
                        decodedNumber += '5';
                        break;
                    case 'M':
                    case 'N':
                    case 'O':
                        decodedNumber += '6';
                        break;
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        decodedNumber += '7';
                        break;
                    case 'T':
                    case 'U':
                    case 'V':
                        decodedNumber += '8';
                        break;
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        decodedNumber += '9';
                        break;
                    default:
                        decodedNumber += phoneNumber[i];
                        break;
                }
            }
            Console.WriteLine(phoneNumber);
            return (decodedNumber);
        }
    }
}