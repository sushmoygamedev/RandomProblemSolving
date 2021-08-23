// TRIGGER
/*string str1 = "";
string str2 = "";

StrangePair instence = new StrangePair();
instence.str1 = str1;
instence.str2 = str2;
Console.WriteLine(instence.CheckStrangePair());*/

using System;

namespace RandomProblemSolving
{
    public class StrangePair
    {
        public string str1;
        public string str2;
        public string  CheckStrangePair()
        {
            bool isPair = false;

            /*if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                isPair = true;
            }
            else
            {
                if (str1.StartsWith(str2[str2.Length - 1]) && str1.EndsWith(str2[0]))
                {
                    isPair = true;
                }
            }

            Console.WriteLine(isPair);*/

            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("Empty or Just Spaces");

                isPair = true;
            }
            else
            {
                Console.WriteLine(str1[0] + " == " + str2[str2.Length - 1] + "\n" + str1[str1.Length - 1] + " == " + str2[0]);
                if (str1[0] == str2[str2.Length - 1] && str1[str1.Length - 1] == str2[0])
                {
                    isPair = true;
                }
            }
            return ("isPair: " + isPair);

        }
    }
}