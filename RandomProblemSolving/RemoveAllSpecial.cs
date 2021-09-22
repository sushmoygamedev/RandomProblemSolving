// TRIGGER
/*//string str = "%fd76$fd(-)6GvKlO.";
string str = "h-d+=rf[]_{}<>.,`~!@#$%^&*(|)";
Console.WriteLine(RemoveAllSpecial.RemoveSpecial(str));*/
namespace RandomProblemSolving
{
    public class RemoveAllSpecial
    {
        public static string RemoveSpecial(string str)
        {
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]) || str[i] == ' ' || str[i] == '-' || str[i] == '_')
                {
                    newStr += str[i];
                }

                /*if ((str[i] >= 0 && str[i] <= 9) || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z') || str[i] == '_' || str[i] == '-' )
                {
                    newStr += str[i];
                }*/

                /*switch (str[i])
                {
                    case '.':
                    case '!':
                    case '@':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '\\':
                    case '*':
                    case '(':
                    case ')':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                    case '<':
                    case '>':
                    case '~':
                    case '+':
                    case '=':
                    case ',':
                    case '`':
                    case '|':
                        newStr += "";
                        break;
                    default:
                        newStr += str[i];
                        break;
                }*/
            }

            return (newStr);
        }
    }
}