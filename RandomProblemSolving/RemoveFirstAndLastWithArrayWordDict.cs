/*TRIGGER*/
/*string[] wordList = new string[] { "door", "automatic", "chickens", "ice", "hapless", "to" };
RemoveFirstAndLastWithArrayWordDict.FirstAndLast(wordList);*/
using System;

namespace RandomProblemSolving
{
    public class RemoveFirstAndLastWithArrayWordDict
    {
        public static void FirstAndLast(string[] wordList)
        {
            string str = "";
            string[] newWordList = new string[wordList.Length];
            for (int i = 0; i < wordList.Length; i++)
            {
                str = wordList[i];
                if (wordList[i].Length > 2)
                {
                    for (int j = 1; j < str.Length - 1; j++)
                    {
                        newWordList[i] += str[j];
                    }
                    Console.WriteLine(newWordList[i]);
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}