using System;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 123;
            string numStr = num.ToString();
            for (int i = numStr.Length-1; i >= 0; i--)
            {
                numStr += numStr[i];
            }
            Console.WriteLine(numStr);*/

            /*string[] bigrams = new string[] {"ay", "be", "ta", "cu"};
            string[] words = new string[] { "maybe", "beta", "abet", "course" };
            bool[] flagsTrue = new bool[bigrams.Length];
            bool[] flagsFalse = new bool[bigrams.Length];
            bool flag = false;

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("----------\n" + words[i] + "\n----------");
                for (int j = 0; j < bigrams.Length; j++)
                {
                    Console.Write(bigrams[j] + ": ");

                    if (words[i].Contains(bigrams[j]))
                    {
                        flagsTrue[j] = true;
                        Console.WriteLine(flagsTrue[j]);
                    }
                    else
                    {
                        flagsFalse[j] = false;
                        Console.WriteLine(flagsFalse[j]);
                    }
                }
            }

            for (int i = 0; i < flagsTrue.Length; i++)
            {
                if (flagsTrue[i] == true)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
                
            }

            Console.WriteLine("----------\nR: " + flag + "\n----------");*/

            string strI = "Healloa";
            string strR = string.Empty;
            string strM = string.Empty;
            int num = 5;

            for (int i = 0; i < strI.Length; i++)
            {
                if (strI[i] == 'a')
                {
                    for (int j = 0; j < num; j++)
                    {
                        strR += strI[i];
                    }
                    break;
                }
                
            }

            Console.WriteLine(strR);

            //strM += strI.Substring(0, strI.IndexOf(strI[i])) + strR + strI.Substring(strI.IndexOf(strI[i]));
            //Console.WriteLine(strM);


            /*for (int i = 0; i < num; i++)
            {
                strR += "a";
            }

            if (num >= 0)
            {
                str = "Ed" + strR + "bit";
            }
            else
            {
                str = "";
            }

            Console.WriteLine(str);*/
        }
    }
}