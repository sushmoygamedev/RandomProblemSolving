/*TRIGGER*/
/*Console.Write("Type a word: ");
string str = Console.ReadLine();
AlphabetSoup instence = new AlphabetSoup();
Console.WriteLine(instence.SortLetters(str));*/
using System;

namespace RandomProblemSolving
{
    public class AlphabetSoup
    {
        public string SortLetters(string str)
        {
            char[] strChar = str.ToCharArray();
            Array.Sort(strChar);
            string newStr = "";
            for (int i = 0; i < strChar.Length; i++)
            {
                newStr += strChar[i];
            }
            return (str + ": " + newStr);

            /*string strJoin = string.Join("", strChar);
            Console.WriteLine(strJoin);*/
        }
    }
}