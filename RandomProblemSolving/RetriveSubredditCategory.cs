//TRIGGER
/*// LET'S DO WITH ARRAY SET OF STRING
string[] str = new string[] {
                "https://www.reddit.com/r/relationships/",
                "https://www.reddit.com/r/mildlyinteresting",
                "https://www.reddit.com/r/funny/",
                "https://www.reddit.com/r/CrappyDesign",
                "https://www.reddit.com/r/confession/",
                "https://www.reddit.com/r/AskMen"
            };

// THIS IS THE SIMPLIFIED WAY
// string str = "https://www.reddit.com/r/relationships/";

RetriveSubredditCategory.Subreddit(str);*/

using System;

namespace RandomProblemSolving
{
    public class RetriveSubredditCategory
    {
        public static void Subreddit(string[] str)
        {
            // LET'S DO WITH ARRAY SET OF STRING
            for (int i = 0; i < str.Length; i++)
            {
                string[] strSplit = str[i].Split('/');
                if (str[i][str[i].Length - 1] == '/')
                {
                    Console.WriteLine(str[i] + ": " + strSplit[strSplit.Length - 2]);
                }
                else
                {
                    Console.WriteLine(str[i] + ": " + strSplit[strSplit.Length - 1]);
                }

            }

            // THIS IS THE SIMPLIFIED WAY
            /*string[] strSplit = str.Split('/');
            string subReddit = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[str.Length - 1] == '/')
                {
                    subReddit = (strSplit[strSplit.Length - 2]);
                }
                else
                {
                    subReddit = (strSplit[strSplit.Length - 1]);
                }
            }
            Console.WriteLine(str + ": " + subReddit);*/
        }
    }
}