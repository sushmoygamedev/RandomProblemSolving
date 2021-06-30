/*TRIGGER*/
/*string str = "Just an example here move along";
Console.WriteLine(WordCount.CountWord(str));*/
namespace RandomProblemSolving
{
    public class WordCount
    {
        public static int CountWord(string str)
        {
            string[] strSplit = str.Split(" ");
            int i = 0;
            foreach (string word in strSplit)
            {
                i++;
            }
            return i;

            /*int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            return count;*/

            /*int i = 0, word = 1;
            while (i <= str.Length - 1)
            {
                if (str[i] == ' ')
                {
                    word++;
                }
                i++;
            }
            Console.WriteLine(word);*/
        }
    }
}
