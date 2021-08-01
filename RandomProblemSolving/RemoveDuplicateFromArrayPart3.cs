// TRIGGER
/*
// SET DATA STRUCTURE
int[] numList = new int[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
int numCount = numList.Length;

RemoveDuplicateFromArrayPart3.SetDataStructure(numList, numCount);

Console.WriteLine("\n");

// MAP DATA STRUCTURE
string[] wordList = new string[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
int wordCount = wordList.Length;

RemoveDuplicateFromArrayPart3.MapDataStructure(wordList, wordCount);
*/

using System;
using System.Collections.Generic; // THIS LIBRARY HELP TO GET SET AND MAP DATA STRUCTURE

namespace RandomProblemSolving
{
    public class RemoveDuplicateFromArrayPart3
    {
        // THIS IS THE 3RD AND FINAL PART REMOVE DUPLICATE FROM ARRAY
        // I WILL TRY TO SOLVE THIS WITH 2 DATA STRUCTURE METHOD FROM SYSTEM.COLLECTION.GENERIC LIBRARY
        // I DON'T KNOW MUCH ABOUT THOSE BUT I RESEARCH A LOT AND FOUND FROM SOME RESOURCES
        // EVEN THO I DON'T KNOW ABOUT IT I WILL TRY TO SHOW YOU BECAUSE,
        // MAYBE SOMEWAY IT HELP YOU IN THE FUTURE
        // LET'S START THEN...

        // SET DATA STRUCTURE
        public static void SetDataStructure(int[] numList, int numCount)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < numCount; i++)
            {
                set.Add(numList[i]);
            }
            foreach (int i in set)
            {
                Console.Write(i + ", ");
            }
        }

        // MAP DATA STRUCTURE
        public static void MapDataStructure(string[] wordList, int wordCount)
        {
            Dictionary<string, Boolean> map = new Dictionary<string, Boolean>();
            for (int i = 0; i < wordCount; i++)
            {
                if (!map.ContainsKey(wordList[i]))
                {
                    Console.Write(wordList[i] + ", ");
                    map[wordList[i]] = true;
                }
            }
        }

        // THIS IS ALL THEN
        // AS MUCH AS POSSIBLE I TRY TO SHOW THIS WAY
        // MAYBE THIS IS NOT MUCH
        // BUT IT WILL HELP
        // THANK YOU FOR WATCHING THIS
    }
}