namespace RandomProblemSolving
{
    public class AmazingEdabit
    {
        public static string Amazing(string str)
        {
            string[] strSplit = str.Split();
            string result = "";
            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "edabit")
                {
                    result = str;
                    break;
                }
                else
                {
                    result = str.Replace("amazing", "not amazing");
                }
            }
            return (result);
        }
    }
}
