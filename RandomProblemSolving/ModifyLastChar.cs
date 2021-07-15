/*TRIGGER*/
/*Console.Write("type a word: ");
string str = Console.ReadLine();
Console.Write("type a number: ");
int n = Convert.ToInt32(Console.ReadLine());

ModifyLastChar instence = new ModifyLastChar();
instence.str = str;
instence.n = n;
Console.WriteLine(instence.RepeatLastChar());*/
namespace RandomProblemSolving
{
    public class ModifyLastChar
    {
        public string str;
        public int n;
        public string RepeatLastChar()
        {
            string strSub = str.Substring(0, str.Length - 1);
            string lastChar = "";
            for (int i = 0; i < n; i++)
            {
                lastChar += (str[str.Length - 1]);
            }
            return (strSub + lastChar);
        }
    }
}