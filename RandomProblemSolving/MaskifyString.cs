// TRIGGER
/*string str = "asfssdf12313jlsfj";
MaskifyString.Makify(str);*/
using System;

namespace RandomProblemSolving
{
    public class MaskifyString
    {
        public static void Makify(string str)
        {
            string maskify = string.Empty;

            for (int i = 0; i < str.Length - 4; i++)
            {
                maskify += "#";
            }

            if (str.Length > 4)
            {
                Console.WriteLine(maskify + "" + str.Substring(str.Length - 4));
            }
            else
            {
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("\"\"");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}