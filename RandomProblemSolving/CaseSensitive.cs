//TRIGGER CODE
//CaseSensitive.isCaseSensitive();
using System;

namespace RandomProblemSolving
{
    public class CaseSensitive
    {
        public static void isCaseSensitive()
        {
            string str1 = "maGIciAN";
            string str2 = "maGIciAN";
            bool result1 = true;
            bool result2 = true;

            for (int i = 0; i < str1.Length; i++)
            {
                if (char.IsUpper(str1[i]))
                {
                    result1 = true;
                }
                else
                {
                    result1 = false;
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (char.IsUpper(str2[i]))
                {
                    result2 = true;
                }
                else
                {
                    result2 = false;
                }
            }

            /*Console.WriteLine(result1);
            Console.WriteLine(result2);*/

            if (result1 == result2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            /*for(int i = 0; i < str1.Length; i++)
            {
                if (Convert.ToInt32(str1[i]) == Convert.ToInt32(str2[i])) {
                    Console.WriteLine(true);
                } else
                {
                    Console.WriteLine(false);
                }
            }*/

            /*if (string.Equals(str1, str2))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/
        }
    }
}
