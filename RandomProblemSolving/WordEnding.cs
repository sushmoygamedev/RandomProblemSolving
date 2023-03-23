using System;

namespace RandomProblemSolving
{
    public class WordEnding
    {
        public static string[] wordList = new string[5];
        public static string wordEnding;
        string[] newWordList = new string[wordList.Length];
        #region draft code
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
        #endregion
        public void AddEnding()
        {
            Console.WriteLine("Insert 5 Word:");
            for (int w = 0; w < wordList.Length; w++)
            {
                Console.Write("{0}. ", w+1);
                wordList[w] = Console.ReadLine();
            }

            Console.Write("Word Ending: ");
            wordEnding = Console.ReadLine();

            for (int i = 0; i < wordList.Length; i++)
            {
                newWordList[i] = wordList[i] + wordEnding;
                Console.WriteLine(i+1 + ". " + (wordList[i] + " + " + wordEnding + " = " + newWordList[i] + " (" + newWordList[i].GetType() + " > " + newWordList.GetType() + ") "));
            }
        }
    }
}
/*
 // RUN
WordEnding test = new WordEnding();
            test.AddEnding();
 */