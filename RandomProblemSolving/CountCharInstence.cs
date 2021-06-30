/*TRIGGER*/
/*string str = "frank and his friends have offered five foxes for sale";
char charInStr = 'f';
Console.WriteLine(CountCharInstence.CountChar(charInStr, str));*/
namespace RandomProblemSolving
{
    public class CountCharInstence
    {
        public static int CountChar(char charInStr, string str)
        {
            int countChar = 0;
            int countResult = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == charInStr)
                {
                    countChar++;
                }

            }
            if (countChar > 0)
            {
                countResult = countChar;
            }
            else
            {
                countResult = 0;
            }
            return countResult;
        }
    }
}