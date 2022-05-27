/* TRIGGER
 string str = "OMG this website is awesome!";
            //AlteringCaps instance = new AlteringCaps();
            AlteringCaps.str = str;
            Console.WriteLine(AlteringCaps.AlteringCapsFunc());
 */
using System;

namespace RandomProblemSolving
{
    public static class AlteringCaps
    {
        public static string str;
        public static string AlteringCapsFunc()
        {
            #region Alterning Caps
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
            return (newStr);
            #endregion
        }
    }
}
