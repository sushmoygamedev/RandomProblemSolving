using System;

namespace RandomProblemSolving
{
    public class StringOddEven
    {
        public static void StringCount()
        {
            string[] strList = new string[] { "apples", "banana", "cherry", "mango", "peach", "pears" };
            for (int i = 0; i < strList.Length; i++)
            {
                int strCount = strList[i].Length;
                bool result = true;
                if (strCount % 2 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                Console.WriteLine(strList[i] + " (" + strCount + "): " + result);
            }
        }
    }
}
