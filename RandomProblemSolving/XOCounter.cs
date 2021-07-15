/*TRIGGER*/
/*string str = "xoxoxoxooxxxo";
Console.WriteLine(XOCounter.CountXO(str.ToLower()));*/
using System;

namespace RandomProblemSolving
{
    public class XOCounter
    {
        public static bool CountXO(string str)
        {
            int counterX = 0;
            int counterO = 0;
            bool result = false;
            string notFoundXO = "";

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'x':
                        counterX++;
                        break;
                    case 'o':
                        counterO++;
                        break;
                    default:
                        break;
                }
                if (str[i] != 'x' && str[i] != 'o')
                {
                    notFoundXO = "XO NOT FOUND!";
                    result = true;
                }
                else
                {
                    notFoundXO = "FOUND!";
                }
            }

            if (counterX == counterO)
            {
                result = true;
            }
            Console.WriteLine(notFoundXO);
            Console.WriteLine("x: " + counterX);
            Console.WriteLine("o: " + counterO);
            return (result);
        }
    }
}