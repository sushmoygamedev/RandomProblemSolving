/*TRIGGER*/
/*string word = "kiwi";
int repeatTimes = 5;
Console.WriteLine(RecursionRepeat.RepeatString(word, repeatTimes));*/
namespace RandomProblemSolving
{
    public class RecursionRepeat
    {
        public static string RepeatString(string word, int repeatTimes)
        {
            string newWord = string.Empty; // string.Empty same as "" (empty quote)

            for (int i = 0; i < repeatTimes; i++)
            {
                newWord += word;
            }

            return (newWord);
        }
    }
}