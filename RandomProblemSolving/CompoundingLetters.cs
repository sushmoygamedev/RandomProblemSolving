#region Trigger
/*string str = "hello";
Console.WriteLine(CompoundingLetters.Accum(str));*/
#endregion
namespace RandomProblemSolving
{
    public class CompoundingLetters
    {
        public static string Accum(string str)
        {
            #region Solution #1
            //string str = "HeLLo";
            string modStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                modStr += (char.ToUpper(str[i]));
                for (int j = 0; j < i; j++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        modStr += (char.ToLower(str[i]));
                    }
                    else
                    {
                        modStr += (str[i]);
                    }
                }
                modStr += ("-");
            }
            return (modStr.Trim('-'));
            #endregion
            #region Solution #2
            /*string str = "RqaEzty";
            string modStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                modStr += char.ToUpper(str[i]);
                if (str[i] != str[str.Length-1])
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (char.IsUpper(str[i]))
                        {
                            modStr += char.ToLower(str[i]);
                        }
                        else
                        {
                            modStr += str[i];
                        }
                    }
                    modStr += '-';
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        modStr += str[i];
                    }
                }
            }
            Console.WriteLine(modStr);*/
            #endregion
        }
    }
}