/*TRIGGER*/
/*string str = "The quick brown fox.";
Console.WriteLine(ReverseString.ReverseStr(str));*/

//using System.Linq;
namespace RandomProblemSolving
{
    public class ReverseString
    {
        public static string ReverseStr(string str)
        {
            string newStr = string.Empty;
            //METHOD #1
            //Console.WriteLine(string.Concat(str.Reverse()));
            //METHOD #2
            /*char[] strChar = str.ToCharArray();
            Array.Reverse(strChar);
            Console.WriteLine(strChar);*/
            //METHOD #3
            for (int i = str.Length - 1; i > -1; i--)
            {
                newStr += (str[i]);
            }

            /*for (int i = str.Length; i > 0; i--)
            {
                newStr += str[i - 1];
            }*/
            return newStr;
        }
    }
}