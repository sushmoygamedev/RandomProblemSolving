/*TRIGGER*/
/*while (true)
{
    Console.Write("Type a word: ");
    string str = Console.ReadLine();
    if (!string.IsNullOrEmpty(str))
    {
        StutteringFunc instence = new StutteringFunc();
        instence.str = str;
        Console.WriteLine(instence.Stuttering());
    }
    else
    {
        Console.WriteLine("No Input Given!!!");
        break;
    }
}*/
namespace RandomProblemSolving
{
    public class StutteringFunc
    {
        public string str;
        public string Stuttering()
        {
            string strSub = str.Substring(0, 2);
            string stutter = string.Empty;
            for (int i = 0; i < 2; i++)
            {
                stutter += strSub + "... ";
            }
            return (stutter + str + "?");
        }
    }
}