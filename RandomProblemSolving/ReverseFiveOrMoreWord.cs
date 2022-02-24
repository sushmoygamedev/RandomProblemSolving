#region Test Case
/*Console.Write("Type Something: ");
string str = Console.ReadLine();
Console.WriteLine("Reversed Form: " + ReverseFiveOrMoreWord.FiveOrMore(str));*/
#endregion
namespace RandomProblemSolving
{
    public static class ReverseFiveOrMoreWord
    {
        public static string FiveOrMore(string str)
        {
            string[] strSplit = str.Split(' ');
            string newStr = string.Empty;
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i].Length >= 5)
                {
                    for (int j = strSplit[i].Length - 1; j > -1; j--)
                    {
                        newStr += strSplit[i][j];
                    }
                    newStr += " ";
                }
                else
                {
                    newStr += strSplit[i] + " ";
                }
            }
            return (newStr.Trim(' '));
        }
    }
}