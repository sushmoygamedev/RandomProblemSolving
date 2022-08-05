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
#region Dynamic
/*string str = "Haoala";
int repeat = 0;
string strR = string.Empty;
char repeatChar = 'a';

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == repeatChar)
    {
        for (int j = 0; j < repeat; j++)
        {
            strR += str[i];
        }
        break;
    }
}

if (repeat < 0)
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine(str.Substring(0, str.IndexOf(repeatChar)) + strR + str.Substring(str.IndexOf(repeatChar) + 1));
    Console.WriteLine(str.Replace("a", strR));
}*/
#endregion