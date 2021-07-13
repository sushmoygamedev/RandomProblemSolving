/*TRIGGER*/
/*string str = "+++###+#+#+#+##+#+#+#+##+#+++#++#+#+#+#+#++#+";
CountHashPlus.CountHP(str);*/

using System;

namespace RandomProblemSolving
{
    public class CountHashPlus
    {
        public static void CountHP(string str)
        {
            int[] countHashPlus = new int[] { 0, 0 };

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '#':
                        countHashPlus[0]++;
                        break;
                    case '+':
                        countHashPlus[1]++;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < countHashPlus.Length; i++)
            {
                Console.Write(countHashPlus[i] + " ");
            }
        }
    }
}