namespace RandomProblemSolving
{
    public class Switcharoo
    {
        public static string str;
        public static string FlipChar()
        {
            string output = string.Empty;

            if (str.Length < 2)
            {
                output = "Incompatible.";
            }
            else
            {
                if (str[0] == str[str.Length - 1])
                {
                    output = "Tow's a pair";
                }
                else
                {
                    output = str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
                }
            }
            return(output);
            //Console.WriteLine(typeof(string) == str.GetType());
        }
    }
}

/*string str = "Anna, Banana";
//Static Class
Switcharoo.str = str;
Console.WriteLine(Switcharoo.FlipChar());
//Object Class
*//*Switcharoo flipChar = new Switcharoo();
flipChar.str = str;
Console.WriteLine(flipChar.FlipChar());*/