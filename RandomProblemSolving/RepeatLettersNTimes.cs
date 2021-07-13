/*TRIGGER*/
/*Console.Write("Type a word: ");
string str = Console.ReadLine();

Console.Write("Type a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(RepeatLettersNTimes.RepeatLetterN(str, n));*/
namespace RandomProblemSolving
{
    public class RepeatLettersNTimes
    {
        public static string RepeatLetterN(string str, int n)
        {
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newStr += str[i];
                }
            }
            return (newStr);
        }
    }
}