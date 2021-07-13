/*TRIGGER*/
/*Console.Write("Type a word: ");
string word = Console.ReadLine();
Console.WriteLine(DoubleLetters.CheckDobule(word));*/
namespace RandomProblemSolving
{
    public class DoubleLetters
    {
        public static string CheckDouble(string word)
        {
            bool isSame = false;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    isSame = true;
                }
            }
            return word + ": " + isSame;
        }
    }
}