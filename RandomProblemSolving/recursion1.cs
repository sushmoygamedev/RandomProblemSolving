using System;
using System.Collections.Generic;
using System.Text;

namespace RandomProblemSolving
{
    class recursion1
    {
        /*public static int CalculateSumRec(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRec(n, m);
            }

            return sum;
        }*/

        public static int recStringLen(string str)
        {
            if (str == "")
            {
                return 0;
            }
            else
            {
                return recStringLen(str.Substring(1)) + 1;
            }
        }
    }
}
