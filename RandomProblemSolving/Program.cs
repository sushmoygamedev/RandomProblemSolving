using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT: ");
            string str = Console.ReadLine();
            char[] strChar = new char[str.Length];
            
            for(int i = 0; i < str.Length; i++)
            {
                strChar[i] = str[i];
            }
            for (int i = 0; i < strChar.Length-1; i++)
            {
                if (strChar[i] > strChar[i+1])
                {
                    char ch = strChar[i];
                    strChar[i] = strChar[i +1];
                    strChar[i + 1] = ch;
                    i = -1;
                }
            }
            string newStr = new string(strChar);
            Console.WriteLine(newStr);

            int count = 0;
            for (int i = 0; i < newStr.Length-1; i++)
            {
                //Console.WriteLine(newStr[i]);
                if(newStr[i] == newStr[i+1])
                {
                    //Console.WriteLine(newStr[i]);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}