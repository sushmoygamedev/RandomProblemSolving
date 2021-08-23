// TRIGGER
/*string str = "Mr. Fox was very naughty".ToLower();
Console.WriteLine(ScottishScreaming.Screaming(str));*/

namespace RandomProblemSolving
{
    public class ScottishScreaming
    {
        public static string Screaming(string str)
        {
            string resultStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                        resultStr += 'e';
                        break;
                    default:
                        resultStr += str[i];
                        break;
                }
            }
            return (resultStr.ToUpper());
        }
    }
}