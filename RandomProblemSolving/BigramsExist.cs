using System;

namespace RandomProblemSolving
{
    public class BigramsExist
    {
        public static void CheckBigrams()
        {
            string[] words = new string[] { "books", "table", "cap", "hostel" };
            string[] bigrams = new string[] { "bo", "ta", "el", "st", "ca" };
            bool[] flagTrue = new bool[bigrams.Length];
            bool[] flagFalse = new bool[bigrams.Length];

            for (int i = 0; i < bigrams.Length; i++)
            {
                Console.WriteLine("----------\n" + bigrams[i] + "\n----------");

                for (int j = 0; j < words.Length; j++)
                {
                    Console.Write(words[j] + ": ");

                    if (words[j].Contains(bigrams[i]))
                    {
                        flagTrue[i] = (true);
                        Console.WriteLine(flagTrue[i]);
                    }
                    else
                    {
                        flagFalse[i] = (false);
                        Console.WriteLine(flagFalse[i]);
                    }
                }
            }

            bool flag = false;
            for (int i = 0; i < flagTrue.Length; i++)
            {
                Console.WriteLine("-========-");
                if (flagTrue[i] == true)
                {
                    flag = true;
                    Console.WriteLine(bigrams[i] + ": " + flag);
                }
                else
                {
                    flag = false;
                    Console.WriteLine(bigrams[i] + ": " + flag);
                    break;
                }

            }

            Console.WriteLine("----------\n" + "Result: " + flag + "\n----------");

            /*for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("----------\n" + words[i] + "\n----------");

                for (int j = 0; j < bigrams.Length; j++)
                {
                    Console.Write(bigrams[j] + ": ");

                    if (words[i].Contains(bigrams[j]))
                    {
                        flagTrue[j] = (true);
                        Console.WriteLine(flagTrue[j]);
                    }
                    else
                    {
                        flagFalse[j] = (false);
                        Console.WriteLine(flagFalse[j]);                    }
                }
            }

            bool flag = false;
            for (int i = 0; i < flagTrue.Length; i++)
            {
                Console.WriteLine("----------");
                if (flagTrue[i] == true)
                {
                    flag = true;
                    Console.WriteLine(bigrams[i]+ ": " + flag);
                }
                else
                {
                    flag = false;
                    Console.WriteLine(bigrams[i] + ": " + flag);
                    break;
                }
                
            }

            Console.WriteLine("----------\n"+"Result: " + flag + "\n----------");*/
        }
    }
}