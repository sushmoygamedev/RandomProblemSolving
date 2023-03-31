//TRIGGER CODE
/*for (int i = 0; i < 4; i++)
            {
                Console.Write("Input First String: ");
                string str1 = Console.ReadLine();
                Console.Write("Input Second String: ");
                string str2 = Console.ReadLine();

                Console.WriteLine("Result: " + CaseInsensitive.match(str1, str2));
            }*/
namespace RandomProblemSolving
{
    public class CaseInsensitive
    {
        public static bool match(string str1, string str2)
        {
            if (str1.ToLower() == str2.ToLower())
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
