using System;

namespace RandomProblemSolving
{
    public class AlphabetSoupSortingAlgorithm
    {
        public void Sorting()
        {
            /**
             * Sorting element with single loops
            */
            // SORT NUMBER
            /*int[] numList = new int[] { 1, 3, 99, 0, 2, 3, 5, 6, 4, 89, 0 };
            int temp;
            for (int i = 0; i < numList.Length-1; i++)
            {
                if (numList[i] > numList[i+1])
                {
                    temp = numList[i];
                    numList[i] = numList[i+1];
                    numList[i+1] = temp;
                    i = -1;
                }
            }
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }*/

            // SORT STRING ARRAY
            /*string str = "hello";
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length-1; i++)
            {
                if (strChar[i] > strChar[i+1])
                {
                    char ch = strChar[i];
                    strChar[i] = strChar[i + 1];
                    strChar[i + 1] = ch;
                    i = -1;
                }
            }
            string newStr = new string(strChar);
            Console.WriteLine(newStr);*/

            /**
             * Sorting element with double loops
            */
            // SORT NUMBER
            /*int[] numList = new int[] { 1, 9, 6, 7, 5, 9 };
            int temp;
            for (int i = 0; i < numList.Length - 1; i++)
            {
                for (int j = i+1; j < numList.Length; j++)
                {
                    if (numList[i] > numList[j])
                    {
                        temp = numList[i];
                        numList[i] = numList[j];
                        numList[j] = temp;
                    }
                }
            }
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }*/
            // SORT STRING ARRAY
            /*string str = "javascript";
            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length-1; i++)
            {
                for (int j = i+1; j < strChar.Length; j++)
                {
                    if (strChar[i] > strChar[j])
                    {
                        char c = strChar[i];
                        strChar[i] = strChar[j];
                        strChar[j] = c;
                    }
                }
            }
            foreach (char c in strChar)
            {
                Console.Write(c);
            }*/

            string str = "geek";
            char[] chars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chars[i] = str[i]; // building char array
            }
            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char c = chars[i]; // a temp variable to store first char in the string array
                        chars[i] = chars[j]; // if condition true swap the element position of previous char
                        chars[j] = c; // after swaping the next char will place after previous char in temp
                    }
                }
            }
            string sortedStr = new string(chars);
            Console.WriteLine(sortedStr);
        }
    }
}