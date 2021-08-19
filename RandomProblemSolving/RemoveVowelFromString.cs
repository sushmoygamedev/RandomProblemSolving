// TRIGGER
/*string str = "Windmills are the greatest threat in the US to both bald and golden eagles. Media claims fictional ‘global warming’ is worse.";
            Console.WriteLine("With Vowel: " + str + "\n");
            Console.WriteLine("Without Vowel: " + RemoveVowelFromString.RemoveVowel(str));*/
namespace RandomProblemSolving
{
    public class RemoveVowelFromString
    {
        public static string RemoveVowel(string str)
        {
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
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
                        newStr += string.Empty;
                        break;
                    default:
                        newStr += str[i];
                        break;
                }
            }
            return (newStr);
        }
    }
}