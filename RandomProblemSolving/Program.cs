using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strList = new string[] { "John", "Taylor", "John", "Pikachu", "Marco", "Macino", "Pikachu", "Pikachu", "Machino", "Macino" };
            int strLen = strList.Length;
            Array.Sort(strList);
            int j = 0;
            for (int i = 0; i < strLen - 1; i++)
            {
                if (strList[i] != strList[i+1])
                {
                    strList[j] = strList[i];
                    j++;
                }
            }
            strList[j++] = strList[strLen - 1];

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(strList[i]);
            }
        }
    }
}