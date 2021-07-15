/*TRIGGER*/
/*string[] wordList = new string[] { "Red", "Blue", "Green", "Pink" };
ReturnFourLetterStr.FourLetter(wordList);*/
using System;

namespace RandomProblemSolving
{
    public class ReturnFourLetterStr
    {
        public static void FourLetter(string[] wordList)
        {
            string[] wordListOf4 = new string[10];
            for (int i = 0; i < wordList.Length; i++)
            {
                if (wordList[i].Length == 4)
                {
                    wordListOf4[i] += wordList[i];
                    Console.WriteLine(wordListOf4[i]);
                }
                else
                {
                    Console.WriteLine("This is not 4 Words!!!");
                }
            }
        }
    }
}