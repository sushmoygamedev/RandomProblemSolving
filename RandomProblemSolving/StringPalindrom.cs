using System;
#region Trigger
/*string testStr = "Not a palindrome";
Console.WriteLine(StringPalindrom.CheckPalindrom(testStr));*/
#endregion
namespace RandomProblemSolving
{
    public class StringPalindrom
    {
        public static bool CheckPalindrom(string str)
        {
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]))
                {
                    newStr += char.ToLower(str[i]);
                }
            }
            Console.WriteLine(newStr);

            string strRev = string.Empty;
            bool isPal = false;
            for (int i = newStr.Length; i > 0; i--)
            {
                strRev += newStr[i - 1];
            }
            Console.WriteLine(strRev);

            if (newStr == strRev)
            {
                isPal = true;
            }
            /*else
            {
                isPal = false;
            }*/
            return (isPal);
        }
    }
}