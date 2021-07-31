//TRIGGER
/*RemoveDuplicateFromArrayPart1.DistinctMethod();*/

using System;
using System.Linq; //FOR DISTINCT METHOD

namespace RandomProblemSolving
{
    public static class RemoveDuplicateFromArrayPart1
    {
        public static void DistinctMethod()
        {
            //USING DISTINCT METHOD FROM LINQ LIBRARY
            //FIRST WE TRY TO USE IT ON INT ARRAY
            /*int[] numList = new int[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 };
            int[] numListRemoveDuplicate = numList.Distinct().ToArray(); //THIS IS ALREADY A NEW ARRAY
            int[] newNumList = new int[numListRemoveDuplicate.Length]; //THIS IS ALSO A NEW ARRAY
            string newArray = string.Empty;*/

            //RESULT
            /*for (int i = 0; i < numListRemoveDuplicate.Length; i++)
            {
                // STORE IN NEW NEW ARRAY
                //newNumList[i] = numListRemoveDuplicate[i];
                *//*if (newNumList[i] != newNumList[newNumList.Length - 1])
                {
                    newArray += newNumList[i] + ", ";
                }
                else
                {
                    newArray += newNumList[i];
                }*//*
                // STORE IN NEW ARRAY
                *//*if (numListRemoveDuplicate[i] != numListRemoveDuplicate[numListRemoveDuplicate.Length - 1])
                {
                    newArray += numListRemoveDuplicate[i] + ", ";
                }
                else
                {
                    newArray += numListRemoveDuplicate[i];
                }*//*
                // STORE IN EXISTING ARRAY
                numList[i] = numListRemoveDuplicate[i];
                *//*if (numList[i] != numListRemoveDuplicate[numListRemoveDuplicate.Length - 1])
                {
                    newArray += numList[i] + ", ";
                }
                else
                {
                    newArray += numList[i];
                }*//*
            }
            //Console.WriteLine(newArray);*/

            //NOW STRING ARRAY LIST
            string[] wordList = new string[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
            int wordListCount = wordList.Length;
            string[] wordRemoveDuplicate = wordList.Distinct().ToArray();
            int wordRemoveDuplicateCount = wordRemoveDuplicate.Length;
            string newResult = ""; // "" DOUBLE QUOTE IS EQUAL TO string.Empty;

            Console.WriteLine("Old Word List");
            for (int i = 0; i < wordListCount; i++)
            {
                Console.Write(wordList[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("New Word List");
            for (int i = 0; i < wordRemoveDuplicateCount; i++)
            {
                if (wordRemoveDuplicate[i] == wordRemoveDuplicate[wordRemoveDuplicateCount - 1])
                {
                    newResult += (wordRemoveDuplicate[i]);
                }
                else
                {
                    newResult += (wordRemoveDuplicate[i] + ", ");
                }
            }
            Console.WriteLine(newResult);

            // THIS IS PART ONE, I WILL SHOW YOU HOW TO REMOVE DUPLICATE WITHOUT USING METHOD
            // TO BE CONTINUED...
        }
    }
}