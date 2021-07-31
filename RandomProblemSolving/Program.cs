using System;
using System.Linq;
namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //USING DISTINC METHOND FROM LINQ LIBRARY
            //FIRST INT ARRAY
            int[] numList = { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
            int[] numListRemoveDuplicate = numList.Distinct().ToArray();
            int[] newNumList = new int[numListRemoveDuplicate.Length];
            string result = string.Empty;
            for (int i = 0; i < numListRemoveDuplicate.Length; i++)
            {
                //numList[i] = numListRemoveDuplicate[i];
                newNumList[i] = numListRemoveDuplicate[i];
                /*Console.WriteLine(newNumList[i]);*/
                if (newNumList[i] == newNumList[newNumList.Length - 1])
                {
                    result += newNumList[i];
                }
                else
                {
                    result += newNumList[i] + ",";
                }
            }
            Console.WriteLine(result);
        }
    }
}