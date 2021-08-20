/*TRIGGER*/
/*string str = "Hey, did you think there is a bomb ?";
Console.WriteLine(FindTheBomb.FindBomb(str));
string str2 = "Commotion in the third, a bomb is found!";
Console.WriteLine(FindTheBomb.FindBomb(str2));
string str3 = "This goes boom!!!";
Console.WriteLine(FindTheBomb.FindBomb(str3));*/
namespace RandomProblemSolving
{
    public class FindTheBomb
    {
        public static string FindBomb(string str)
        {
            str = str.Remove(str.Length - 1);

            string[] strSplit = str.Split(' ');
            string output = string.Empty;

            /*Console.WriteLine(str.Length);
            Console.WriteLine(strSplit.Length);*/

            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i].ToLower() == "bomb")
                {
                    output = ("Duck!!!");
                    break;
                }
                else
                {
                    output = ("There is no bomb, relax.");
                }
            }

            return (output);
        }
    }
}