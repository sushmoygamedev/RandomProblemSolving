/*TRIGGER CODE*/
/*
string str = "Indoor Voice";
LowerUpperMixed instence = new LowerUpperMixed();
instence.GetCase(str);
*/
using System;

namespace RandomProblemSolving
{
    public class LowerUpperMixed
    {
        public void GetCase(string str)
        {
            if (str != str.ToUpper() && str != str.ToLower())
            {
                Console.WriteLine("Mixed");
            }
            else if (str == str.ToUpper())
            {
                Console.WriteLine("Upper");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}
