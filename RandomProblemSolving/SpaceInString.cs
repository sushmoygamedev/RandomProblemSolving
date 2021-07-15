/*TRIGGER*/
/*Console.Write("Type a word: ");
string str = Console.ReadLine();
SpaceInString instence = new SpaceInString();
instence.str = str;
Console.WriteLine(instence.SpaceChar());*/
namespace RandomProblemSolving
{
    public class SpaceInString
    {
        public string str;
        public string SpaceChar()
        {
            string strNew = "";
            for (int i = 0; i < str.Length; i++)
            {
                strNew += str[i] + " ";
            }
            return (strNew.Trim());

            /*char[] strChar = str.ToCharArray();
            string strJoin = string.Join(" ", strChar);
            Console.WriteLine(strJoin);*/
        }
    }
}