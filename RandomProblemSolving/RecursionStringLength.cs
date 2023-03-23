using System;

namespace RandomProblemSolving
{
    class RecursionStringLength
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
/*string str = "wordcounter";
            str += '\0';
            *//*int x = 0;
            while (str[x] != '\0')
                x++;
            Console.WriteLine(x);*//*
            int c = 0;
            for (int i = 0; str[i] != '\0'; i++)
            {
                c = i;
            }
            Console.WriteLine(c);*/

/*
 // TRIGGER
string str = "apple";
Console.WriteLine(RecursionStringLength.recStringLen(str));
 */