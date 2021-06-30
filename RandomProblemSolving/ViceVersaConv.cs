using System;

namespace RandomProblemSolving
{
    public class ViceVersaConv
    {
        public string toInt(string str)
        {
            Console.WriteLine("Input: "+ "\"" + str + "\"" + " > " + str.GetType());
            int numStrToInt = Convert.ToInt32(str);
            return ("Output: " + numStrToInt + " > " + numStrToInt.GetType());
        }

        public string toStr(int num)
        {
            Console.WriteLine("Input: " + num + " > " + num.GetType());
            string numIntToStr = Convert.ToString(num);
            return ("Output: " + "\"" + numIntToStr + "\"" + " > " + numIntToStr.GetType());
        }

        /*Console.WriteLine("Before Conversion:");
        string numStr = "77";
        int numInt = 77;
        Console.WriteLine("\"" + numStr + "\"" + ": " + "(" + numStr.GetType() + ")");
        Console.WriteLine(numInt + ": " + "(" + numInt.GetType() + ")");

        Console.WriteLine("---------------------------------------");

        Console.WriteLine("After Conversion:");
        int numStrToInt = Convert.ToInt32(numStr);
        string numIntToStr = Convert.ToString(numInt);
        Console.WriteLine(numStrToInt + ": " + "(" + numStrToInt.GetType() + ")");
        Console.WriteLine("\"" + numIntToStr + "\"" + ": " + "(" + numIntToStr.GetType() + ")");*/
    }
}
