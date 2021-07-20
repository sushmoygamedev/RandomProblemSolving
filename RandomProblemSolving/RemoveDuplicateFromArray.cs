using System.Collections.Generic;
namespace RandomProblemSolving
{
    public class RemoveDuplicateFromArray
    {
        //SET DATA STRUCTURE
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

        //MAP DATA STRUCTURE
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

        
        //int[] arr = { 1, 2, 5, 1, 7, 2, 4, 2 };
        /*int n = arr.Length;
        removeDupDict(arr, n);*/
        //removeDupHashSet(arr);

        //int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
        //int n = arr.Length;
        //int[] temp = new int[n];
        //int j = 0;

        //USING EXTRA SPACE
        /*for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] != arr[i+1])
            {
                temp[j] = arr[i];
                j++;
            }
        }
        temp[j++] = arr[n - 1];

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
        arr[j++] = arr[n - 1];

        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(arr[i]);
        }*/

        /*string[] strList = new string[] { "John", "Taylor", "John", "Pikachu", "Marco", "Macino", "Pikachu", "Pikachu", "Machino", "Macino" };
        Array.Sort(strList);
        int n = strList.Length;
        string[] temp = new string[n];
        int j = 0;*/

        //USING EXTRA SPACE
        /*for (int i = 0; i < n - 1; i++)
        {
            if (strList[i] != strList[i+1])
            {
                temp[j] = strList[i];
                j++;
            }
        }
        temp[j++] = strList[n - 1];

        for (int i = 0; i < j; i++)
        {
            strList[i] = temp[i];
            Console.WriteLine(strList[i]);
        }*/

        //USING CONSTANT EXTRA SPACE
        /*for (int i = 0; i < n - 1; i++)
        {
            if (strList[i] != strList[i + 1])
            {
                strList[j] = strList[i];
                j++;
            }
        }
        strList[j++] = strList[n - 1];
        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(strList[i]);
        }*/
    }
}