using System;

namespace RandomProblemSolving
{
    public class AlmostPalindrome2
    {
        static int count;
        static void AlmostFunc2(string firstHalf, string secondHalf, string str)
        {
            Console.WriteLine(firstHalf);
            secondHalf = str.Substring(str.Length / 2);

            for (int i = 0; i < secondHalf.Length; i++)
            {
                //Console.WriteLine(firstHalf[i]);
                Console.Write(secondHalf[secondHalf.Length - i - 1]);

                if (firstHalf[i] != secondHalf[secondHalf.Length - i - 1])
                {
                    count++;
                }
            }
        }

        public static string AlmostExe2(string str)
        {
            string firstHalf, secondHalf = "";
            //int count = 0;
            bool flag = false;

            Console.WriteLine(str);

            if (str.Length % 2 == 0)
            {
                firstHalf = str.Substring(0, str.Length / 2);
                #region unuse code
                /*Console.WriteLine(firstHalf);
                secondHalf = str.Substring(str.Length / 2);*/
                //Console.WriteLine(secondHalf);

                /*for (int i = 0; i < secondHalf.Length; i++)
                {
                    //Console.WriteLine(firstHalf[i]);
                    Console.Write(secondHalf[secondHalf.Length - i - 1]);

                    if (firstHalf[i] != secondHalf[secondHalf.Length - i - 1])
                    {
                        count++;
                    }
                }*/
                #endregion
                AlmostFunc2(firstHalf, secondHalf, str);
            }
            else
            {
                firstHalf = str.Substring(0, str.Length / 2 + 1);
                #region unuse code
                /*Console.WriteLine(firstHalf);
                secondHalf = str.Substring(str.Length / 2);*/
                //Console.WriteLine(secondHalf);

                /*for (int i = 0; i < secondHalf.Length; i++)
                {
                    //Console.WriteLine(firstHalf[i]);
                    Console.Write(secondHalf[secondHalf.Length - i - 1]);

                    if (firstHalf[i] != secondHalf[secondHalf.Length - i - 1])
                    {
                        count++;
                    }
                }*/
                #endregion
                AlmostFunc2(firstHalf, secondHalf, str);
            }

            if (count == 1)
            {
                flag = true;
            }

            return ("\ncount: " + count + " - " + flag);
        }
    }
}

/*
 //TEST
    string str = "1234312";
    Console.WriteLine(AlmostPalindrome2.AlmostExe2(str));
 */