/*TRIGGER*/
/*string str = "Earth Day";
Console.WriteLine(ReverseCapitalize.RevStrCap(str));*/
namespace RandomProblemSolving
{
    public class ReverseCapitalize
    {
        public static string RevStrCap(string str)
        {
            string newStr = string.Empty;
            for (int i = str.Length; i > 0; i--)
            {
                newStr += str[i - 1];
            }

            /*for (int i = str.Length-1; i > -1; i--)
            {
                newStr += str[i];
            }*/

            return (newStr.ToUpper());
        }
    }
}