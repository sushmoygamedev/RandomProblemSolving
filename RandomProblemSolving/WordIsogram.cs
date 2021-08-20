// TRIGGER
/*
 string word = "Consecutive".ToLower();
Console.WriteLine(WordIsogram.Isogram(word));
 */
using System;

namespace RandomProblemSolving
{
    public class WordIsogram
    {
        public static bool Isogram(string word)
        {
            char[] wordChar = word.ToCharArray();
            //char[] word = "Algorism".ToCharArray();
            Array.Sort(wordChar);
            bool isIsogram = true;

            Console.WriteLine(word);
            Console.WriteLine(wordChar);

            for (int i = 0; i < wordChar.Length - 1; i++)
            {
                if (wordChar[i] == wordChar[i + 1])
                {
                    isIsogram = false;
                }
            }
            return (isIsogram);
        }
    }
}