/*TRIGGER*/
/*
string str = "WHAT DO YOU MEAN WE'RE OUT OF MONEY";
Console.WriteLine(Wumbology.Wombo(str));
*/
namespace RandomProblemSolving
{
    public class Wumbology
    {
        public static string Wombo(string str)
        {
            char ch = ' ';
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if (ch == 'M')
                {
                    ch = 'W';
                }
                result += ch;
            }
            return (result);

            //char[] chArray = str.ToCharArray();
            /*Console.WriteLine("Original String: " + str);*/
            /*Console.WriteLine("Modified String: " + str.Replace('M', 'W'));*/
            /*for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] == 'M')
                {
                    chArray[i] = 'W';
                }
            }
            string result = new string(chArray);
            Console.WriteLine(result);*/
        }
    }
}
