/*TRIGGER*/
/*string str = Console.ReadLine();
Console.WriteLine(NameShuffle.Shuffle(str));*/
namespace RandomProblemSolving
{
    public class NameShuffle
    {
        public static string Shuffle(string str)
        {
            int strSpaceIndex = str.IndexOf(' ');
            string firstName = str.Substring(0, strSpaceIndex);
            string lastName = str.Substring(strSpaceIndex + 1);
            return (lastName + " " + firstName);

            /*string[] strSplit = str.Split(' ');
            string firstName = strSplit[0];
            string lastName = strSplit[1];
            Console.WriteLine(lastName + " " + firstName);*/
        }
    }
}