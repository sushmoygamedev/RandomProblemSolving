/*TRIGGER*/
/*string str = "My friend Dylan got distracted in school.";
Console.WriteLine(CountDs.CountD(str));*/
namespace RandomProblemSolving
{
    public class CountDs
    {
        public static string CountD(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'D' || str[i] == 'd')
                {
                    count++;
                }
            }
            return ("Result is: " + count);
        }
    }
}