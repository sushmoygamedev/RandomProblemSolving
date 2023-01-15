using System;

namespace RandomProblemSolving
{
    public class AlmostPalindrome
    {
        static int count = 0;

        static void AlmostFunc(string str, int i)
        {
            Console.Write(str[i]);
            Console.Write(str[str.Length - i - 1] + "\n");

            if (str[i] != str[str.Length - i - 1])
            {
                count++;
            }
        }
        public string AlmostExe(string str)
        {
            
            bool flag = false;

            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    AlmostFunc(str, i);
                }
            }
            else
            {
                for (int i = 0; i < str.Length / 2 + 1; i++)
                {
                    AlmostFunc(str, i);
                }
            }

            if (count == 1)
            {
                flag = true;
            }

            return (count + " " + flag);
        }
    }
}

/*
 //TEST
    string str = "abccia";
    AlmostPalindrome instance = new AlmostPalindrome();
    Console.WriteLine(instance.AlmostExe(str));
 */