using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace RandomProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alterning Caps
            /*string str = "How are you?";
            char[] strChar = str.ToCharArray();
            int charCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                if (charCounter % 2 == 0)
                {
                    strChar[i] = char.ToUpper(strChar[i]);
                }
                else
                {
                    strChar[i] = char.ToLower(strChar[i]);
                }
                charCounter++;
                Console.WriteLine(charCounter);
            }
            string newStr = new string(strChar);
            Console.WriteLine(newStr);*/
            #endregion

            string str = "OMG this website is awesome!";
            char[] strChar = str.ToCharArray();
            int j = 0;
            for (int i = 0; i < strChar.Length; i++)
            {
                if (strChar[i] == ' ')
                {
                    continue;
                }
                if (j % 2 == 0)
                {
                    strChar[i] = Char.ToUpper(strChar[i]);
                }
                else
                {
                    strChar[i] = Char.ToLower(strChar[i]);
                }
                j++;
            }
            string newStr = new string(strChar);
            Console.WriteLine(newStr);
        }
    }
}