/*TRIGGER*/
/*string word = Console.ReadLine();
Console.WriteLine(VowelsC.CountVowel(word));*/
namespace RandomProblemSolving
{
    public class VowelsC
    {
        public static int CountVowel(string word)
        {
            int countVowel = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        countVowel++;
                        break;
                    default:
                        break;
                }
            }
            return (countVowel);
        }
    }
}