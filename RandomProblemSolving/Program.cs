using System;
using System.Linq;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[] { 1, 0, 1, 0 };
            int[] removeDuplicate = numList.Distinct().ToArray();
            int[] newNumList = new int[removeDuplicate.Length];
            string result = string.Empty;
            
            for (int i = 0; i < removeDuplicate.Length; i++)
            {
                newNumList[i] = removeDuplicate[i];
                result += numList[i] + ", ";
            }
            Console.WriteLine(result);
        }
    }
}