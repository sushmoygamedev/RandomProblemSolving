/*TRIGGER*/
/*string str = Console.ReadLine();
Console.WriteLine(FindIdentical.IsIdentical(str));*/
namespace RandomProblemSolving
{
    public class FindIdentical
    {
        public static bool IsIdentical(string str)
        {
            bool result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[0])
                {
                    result = false;
                }
            }
            return (result);
        }
    }
}