using System;

namespace RandomProblemSolving
{
    public class ConvertHex
    {
        public string TextHex(string str)
        {
            string hex = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine("quotient:" + Convert.ToInt32(str[i] / 16) + " " + "remainder: " + Convert.ToInt32(str[i] % 16));
                int quotient = Convert.ToInt32(str[i] / 16);
                int remainder = Convert.ToInt32(str[i] % 16);

                switch (remainder)
                {
                    case 10:
                        hex += quotient + "a";
                        break;
                    case 11:
                        hex += quotient + "b";
                        break;
                    case 12:
                        hex += quotient + "c";
                        break;
                    case 13:
                        hex += quotient + "d";
                        break;
                    case 14:
                        hex += quotient + "e";
                        break;
                    case 15:
                        hex += quotient + "f";
                        break;
                    default:
                        hex += quotient + "" + remainder;
                        break;
                }
                hex += " ";
            }

            return ("INPUT: " + str + "\nHEX: " + hex.Trim(' '));
        }
    }
}

/*
 //TEST
 //string str = "Marty Poppinson";

            ConvertHex instance = new ConvertHex();
            Console.Write("INPUT YOUR TEXT: ");
            string hex = instance.TextHex(Console.ReadLine());
            Console.WriteLine(hex);
 */