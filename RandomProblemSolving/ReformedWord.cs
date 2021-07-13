/*TRIGGER*/
/*while (true)
{
    Console.Write("Type First Word: ");
    string str1 = Console.ReadLine();
    Console.Write("Type Second Word: ");
    string str2 = Console.ReadLine();

    if(!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(str2))
    {
        Console.WriteLine(ReformedWord.Reform(str1, str2));
    }
    else
    {
        Console.WriteLine("No Input Given!!!");
        break;
    }
}*/
namespace RandomProblemSolving
{
    public class ReformedWord
    {
        public static string Reform(string str1, string str2)
        {
            return (char.ToUpper(str1[0]) + str1.Substring(1) + "" + str2);
        }
    }
}