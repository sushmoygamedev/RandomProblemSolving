#region TestCase
/*string str1 = "house";
string str2 = "fly";

// Public Modifier
LetterDistance instance = new LetterDistance();
Console.WriteLine(instance.CalcDistance(str1, str2));

// Static Modifier
//Console.WriteLine(LetterDistance.CalcDistance(str1, str2));*/
#endregion
namespace RandomProblemSolving
{
    public class LetterDistance
    {
        public int CalcDistance(string str1, string str2)
        {
            int sum = 0;
            int result = 0;
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1[i] > str2[i])
                    {
                        sum += (str1[i] - str2[i]);
                    }
                    else
                    {
                        sum += (str2[i] - str1[i]);
                    }
                }
                result = (sum + (str1.Length - str2.Length));
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str2[i] > str1[i])
                    {
                        sum += str2[i] - str1[i];
                    }
                    else
                    {
                        sum += str1[i] - str2[i];
                    }
                }
                result = (sum + (str2.Length - str1.Length));
            }
            return (result);
        }
    }
}