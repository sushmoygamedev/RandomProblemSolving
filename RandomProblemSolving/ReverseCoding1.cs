namespace RandomProblemSolving
{
    public class ReverseCoding1
    {
        static string newStr = string.Empty;

        static void RepeatFunc(string str, int repeatCount, int i)
        {
            for (int j = 0; j < repeatCount; j++)
            {
                newStr += (str[i - 1]);
            }
        }
        public static string ReverseCoding(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '1':
                        newStr += (str[i - 1]);
                        break;
                    case '2':
                        RepeatFunc(str, 2, i);
                        break;
                    case '3':
                        RepeatFunc(str, 3, i);
                        break;
                    case '4':
                        RepeatFunc(str, 4, i);
                        break;
                    case '5':
                        RepeatFunc(str, 5, i);
                        break;
                    case '6':
                        RepeatFunc(str, 6, i);
                        break;
                    case '7':
                        RepeatFunc(str, 7, i);
                        break;
                    case '8':
                        RepeatFunc(str, 8, i);
                        break;
                    case '9':
                        RepeatFunc(str, 9, i);
                        break;
                    default:
                        newStr += "";
                        break;
                }
            }
            return (newStr);
        }
    }
}

/*
 //TEST
    string str = "A1B2C3D4";
    string output = ReverseCoding1.ReverseCoding(str);
    Console.WriteLine("INPUT: " + str + "\nOUTPUT: " + output);
 */