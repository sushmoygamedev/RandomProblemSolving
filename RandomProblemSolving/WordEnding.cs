using System;

namespace RandomProblemSolving
{
    public class WordEnding
    {
        public static string[] wordList = new string[5];
        public static string wordEnding;
        string[] newWordList = new string[wordList.Length];

        /*public void AddEnding()
        {
            Console.Write("Insert 5 Word: ");
            for (int w = 0; w < wordList.Length; w++)
            {
                wordList[w] = Console.ReadLine();
            }

            Console.Write("Word Ending: ");
            wordEnding = Console.ReadLine();

            for (int i = 0; i < wordList.Length; i++)
            {
                newWordList[i] = wordList[i] + wordEnding;
                Console.WriteLine ((wordList[i] + " + " + wordEnding + " = " + newWordList[i] + " (" + newWordList[i].GetType() + " > " + newWordList.GetType() + ") "));
            }
        }*/

        public void AddEnding()
        {
            Console.Write("Insert 5 Word: ");
            for (int w = 0; w < wordList.Length; w++)
            {
                wordList[w] = Console.ReadLine();
            }

            Console.Write("Word Ending: ");
            wordEnding = Console.ReadLine();

            for (int i = 0; i < wordList.Length; i++)
            {
                newWordList[i] = wordList[i] + wordEnding;
                Console.WriteLine((wordList[i] + " + " + wordEnding + " = " + newWordList[i] + " (" + newWordList[i].GetType() + " > " + newWordList.GetType() + ") "));
            }
        }
    }
}
