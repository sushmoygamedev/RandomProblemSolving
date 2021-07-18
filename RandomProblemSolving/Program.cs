using System;
using System.Collections.Generic;

namespace RandomProblemSolving
{
    class Program
    {
        /*static void removeDupHashSet(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }
            foreach (var item in set)
            {
                Console.Write(item + ", ");
            }
        }*/

        /*static void removeDupDict(int[] arr, int n)
        {
            Dictionary<int, Boolean> mp = new Dictionary<int, Boolean>();
            for (int i = 0; i < n; ++i)
            {
                if (!mp.ContainsKey(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
                mp[arr[i]] = true;
            }
        }*/
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 5, 1, 7, 2, 4, 2 };
            /*int n = arr.Length;
            removeDupDict(arr, n);*/
            //removeDupHashSet(arr);

            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int n = arr.Length;
            //int[] temp = new int[n];
            int j = 0;

            //USING EXTRA SPACE
            /*for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    temp[j] = arr[i];
                    j++;
                }
            }
            temp[j] = arr[n - 1];

            for (int i = 0; i < j; i++)
            {
                arr[i] = temp[i];
                Console.Write(arr[i] + " ");
            }*/

            //USING CONSTANT SPACE
            /*for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    arr[j] = arr[i];
                    j++;
                }
            }
            arr[j] = arr[n - 1];

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
        }
    }
}