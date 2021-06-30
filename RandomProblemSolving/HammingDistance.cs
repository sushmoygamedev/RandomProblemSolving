/*TRIGGER*/
/*string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

HammingDistance instence = new HammingDistance();
instence.str1 = str1;
instence.str2 = str2;
Console.WriteLine(instence.Diff());*/
using System;

namespace RandomProblemSolving
{
    public class HammingDistance
    {
        public string str1;
        public string str2;

        public int Diff()
        {
            int countDiff = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    countDiff++;
                    Console.WriteLine("Test Success!!!");
                }
            }
            return (countDiff);
        }
    }
}