// TRIGGER
/*
 string str = "43/2";
            FractionGreaterThanOne instence = new FractionGreaterThanOne();
            instence.str = str;
            Console.WriteLine(instence.Fraction());
 */
using System;

namespace RandomProblemSolving
{
    public class FractionGreaterThanOne
    {
        public string str;
        public bool Fraction()
        {
            string[] strSplit = str.Split('/');
            float firstNumber = Convert.ToSingle(strSplit[0]);
            float secondNumber = Convert.ToSingle(strSplit[1]);
            bool fraction = false;

            /*int firstNumber = Convert.ToInt32(strSplit[0]);
            int secondNumber = Convert.ToInt32(strSplit[1]);*/

            Console.WriteLine(firstNumber / secondNumber);
            if (firstNumber / secondNumber > 1)
            {
                fraction = true;
            }
            return (fraction);
        }
    }
}