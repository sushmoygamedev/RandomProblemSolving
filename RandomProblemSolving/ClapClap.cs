/*TRIGGER*/
/*string str = "CCClaClClap!Clap!ClClClap!!";
Console.WriteLine(ClapClap.ClapCount(str));*/
namespace RandomProblemSolving
{
    public class ClapClap
    {
        public static string ClapCount(string str)
        {
            int length = str.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == 'C')
                {
                    count++;
                }
            }
            return ("Clap Count: " + count);
        }
    }
}