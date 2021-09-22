// TRIGGER
/*string str = "1f you c4n r34d 7h15, you r34lly n33d 2 g37 l41d";
Console.WriteLine(CapitalizeFirstLetterEachWord.CapLetterWord(str));*/
namespace RandomProblemSolving
{
    public class CapitalizeFirstLetterEachWord
    {
        public static string CapLetterWord(string str)
        {
            string[] strSplit = str.Split(' ');

            string newStr = string.Empty;

            for (int i = 0; i < strSplit.Length; i++)
            {
                newStr += (char.ToUpper(strSplit[i][0]) + strSplit[i].Substring(1) + " ");
            }

            return (newStr.Trim(' '));
        }
    }
}