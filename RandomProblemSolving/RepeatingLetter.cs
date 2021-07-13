/*TRIGGER*/
/*string str = "Hello World!";
Console.WriteLine(RepeatingLetter.DoubleChar(str));*/
namespace RandomProblemSolving
{
    public class RepeatingLetter
    {
        public static string DoubleChar(string str)
        {
            string newStr = string.Empty; // string.Empty same as ""(empty quote)
            int charRepeat = 2;
            for (int i = 0; i < str.Length; i++)
            {
                /*newStr = str[i] + "" + str[i];*/ //Simple
                for (int j = 0; j < charRepeat; j++)
                {
                    newStr += str[i];
                }
            }
            return (newStr);
        }
    }
}