//TRIGGER CODE
/*Console.Write("Insert a Number: ");
int repeatCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Edaaaaabit.Edbit(repeatCount));*/
namespace RandomProblemSolving
{
    public class Edaaaaabit
    {
        public static string Edbit(int number)
        {
            string repeatChar = "";
            string result;

            for (int i = 0; i < number; i++)
            {
                repeatChar += "a";
            }

            if (number >= 0)
            {
                result = ("Ed" + repeatChar + "bit");
            }
            else
            {
                result = ("\"\"");
            }

            return (result);
        }
    }
}
