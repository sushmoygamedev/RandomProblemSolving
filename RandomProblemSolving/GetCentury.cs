// TRIGGER
/*GetCentury.Century();*/

using System;

namespace RandomProblemSolving
{
    public class GetCentury
    {
        public static void Century()
        {
            /*Console.Write("Input a year between 1000 to 2010: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year%100 == 00)
            {
                Console.WriteLine(year + ": " + year/100 + "th Century");
            }
            else
            {
                Console.WriteLine(year + ": " + (year/100+1) + "th Century");
            }*/

            int yearStart = 1000;
            int yearEnd = 2010;
            int yearD = 100;

            for (int i = yearStart; i <= yearEnd; i++)
            {
                if (i % yearD == 00)
                {
                    Console.WriteLine(i + ": " + i / yearD + "th Century");
                }
                else
                {
                    Console.WriteLine(i + ": " + (i / yearD + 1) + "th Century");
                }
            }
        }
    }
}