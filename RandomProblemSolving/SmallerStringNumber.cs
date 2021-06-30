/*TRIGGER*/
/*string n1 = "16";
string n2 = "16";
Console.WriteLine(SmallerStringNumber.compNum(n1, n2));*/
using System;

namespace RandomProblemSolving
{
    public class SmallerStringNumber
    {
        public static string compNum(string n1, string n2)
        {
            /*int strN1 = int.Parse(n1);
            int strN2 = int.Parse(n2);*/
            int strN1 = Convert.ToInt32(n1);
            int strN2 = Convert.ToInt32(n2);
            string result = "";

            if (strN1 < strN2)
            {
                result = (n1 + "(" + n1.GetType() + ")");
            }
            else
            {
                result = (n2 + "(" + n2.GetType() + ")");
            }
            return result;
        }
    }
}