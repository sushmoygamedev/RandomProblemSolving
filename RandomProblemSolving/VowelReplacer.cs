/*TRIGGER*/
/*Console.Write("Type a sentence: ");
string str = Console.ReadLine();
Console.Write("Replace vowel with: ");
char replaceVowel = Convert.ToChar(Console.ReadLine());
Console.Write("Replace result: ");
Console.WriteLine(VowelReplacer.Replacer(str, replaceVowel));*/
namespace RandomProblemSolving
{
    public class VowelReplacer
    {
        public static string Replacer(string str, char replaceVowel)
        {
            //char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
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
                        newStr += replaceVowel;
                        break;
                    default:
                        newStr += str[i];
                        break;
                }
                /*if (str[i] == vowel[0] || str[i] == vowel[1] || str[i] == vowel[3] || str[i] == vowel[4])
                {
                    newStr += replaceVowel;
                }
                else
                {
                    newStr += str[i];
                }*/
            }
            return (newStr);
            /*for (int i = 0; i < vowel.Length; i++)
            {
                str = str.Replace(vowel[i], replaceVowel);
            }
            Console.WriteLine(str);*/
        }
    }
}