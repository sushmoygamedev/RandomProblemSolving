namespace RandomProblemSolving
{
    public class CensordString
    {
        public string str;
        public string vow;

        public string ReplaceVowelCensord()
        {
            string newStr = "";
            int j = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    newStr += vow[j];
                    j++;
                }
                else
                {
                    newStr += str[i];
                }
            }

            return(newStr);
        }
    }
}

/*
// TEST
string str = "*l*ph*nt";
string vow = "Eea";

CensordString censordString = new CensordString();
censordString.str = str;
censordString.vow = vow;
Console.WriteLine(censordString.ReplaceVowelCensord());
 */