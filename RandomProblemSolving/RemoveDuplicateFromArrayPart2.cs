//TRIGGER
/*RemoveDuplicateFromArrayPart2.CustomDistinct();*/

using System;

namespace RandomProblemSolving
{
    public class RemoveDuplicateFromArrayPart2
    {
        public static void CustomDistinct()
        {
            // THIS IS PART TWO OF REMOVE DUPLICATE FROM ARRAY
            // ON THIS PART WE SEE REMOVE DUPLICATE ELEMENT FROM AN ARRAY WITHOUT USING ANY METHOD OR LIBRARY
            // THERE ARE TWO WAYS TO SOLVE THIS PROBLEM I FOUND ON THE INTERNET SO FAR
            // AND LEARNED HOW THAT WORK
            // LETS GET TO WORK

            // METHOD #1 USING EXTRA SPACE
            /*int[] numList = new int[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
            int numListCount = numList.Length;
            Array.Sort(numList); // ‍SORTING IS IMPORTANT, WITHOUT SORTING CANNOT CHECK THE NEXT ELEMENT IN THE ARRAY
            int[] newNumList = new int[numListCount];
            int j = 0;
            string finalArray = string.Empty;

            for (int i = 0; i < numListCount-1; i++)
            {
                if (numList[i] != numList[i+1]) // HERE WHERE CHECK THE NEXT ELEMENT SAME OR NOT
                {
                    newNumList[j] = numList[i];
                    j++;
                }
            }
            newNumList[j++] = numList[numListCount - 1];

            for (int i = 0; i < j; i++)
            {
                finalArray += newNumList[i] + ", ";
            }
            Console.WriteLine(finalArray);*/

            // METHOD #2 USING CONSTANT SPACE
            string[] wordList = new string[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
            int wordCount = wordList.Length;
            Array.Sort(wordList);
            int j = 0;
            string finalResult = "";
            /*Console.Write("THIS IS HOW SORTED ARRAY LOOK LIKE: ");
            for (int i = 0; i < wordCount; i++)
            {
                Console.Write(wordList[i] + ", ");
            }*/

            for (int i = 0; i < wordCount - 1; i++)
            {
                if (wordList[i] != wordList[i + 1])
                {
                    wordList[j] = wordList[i]; // THIS REPLACE THE OLD ARRAY WITH NEW ARRAY ON THE SAME ARRAY
                    j++;
                }
            }
            wordList[j++] = wordList[wordCount - 1];

            for (int i = 0; i < j; i++)
            {
                finalResult += wordList[i] + " ";
            }
            Console.WriteLine(finalResult);

            // HERE THE TWO WAY TO SOLVE WITHOUT USING EXTERNAL METHOD
            // ON PART 3 I WILL SHOW YOU DATA STRUCTURE METHOD SET ARRAY AND MAP ARRAY
            // I DON'T KNOW MUCH ABOUT THOSE, FOUND ON SOME RESOURSES
            // BUT I WILL SHOW IF ANYONE GET USEFUL TO THAT, I THINK IT HELPS
            // SO I WILL SHOW IT ON PART 3
            // TO BE CONTINUED...
        }
    }
}