// TRIGGER
/*string str = "Nemo is a clown fish, he has white and orange stripes. Nemo , come back! Nemo";
FindingNemo instence = new FindingNemo();
instence.str = str;
Console.WriteLine(instence.FoundNemo());*/

namespace RandomProblemSolving
{
    public class FindingNemo
    {
        public string str;
        public string FoundNemo()
        {
            string[] strSplit = str.Split(' ');
            int i = 0;
            string output = string.Empty;
            foreach (var word in strSplit)
            {
                if (word == "Nemo")
                {
                    output = "I found Nemo at " + (i + 1) + "!";
                    break;
                }
                else
                {
                    output = "I can't find Nemo :(";
                }
                i++;
            }

            return (output);
        }
    }
}