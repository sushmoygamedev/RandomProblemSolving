//TRIGGER
/*
string[] strList = new string[]
{
    "https://www.reddit.com/r/funny/",
    "https://www.reddit.com/r/relationships/",
    "https://www.reddit.com/r/mildlyinteresting/",
    "https://www.reddit.com/r/CrappyDesign/",
    "https://www.reddit.com/r/confession/",
    "https://www.reddit.com/r/AskMen/",
    "https://www.reddit.com/r/wholesomememes"
};

RetriveSubReddit.SubReddit(strList); 
*/
using System;

namespace RandomProblemSolving
{
    public class RetriveSubReddit
    {
        public static void SubReddit(string[] strList)
        {
            string[] strSplit = new string[] { };

            for (int i = 0; i < strList.Length; i++)
            {
                Console.Write(strList[i] + ": ");

                strSplit = strList[i].Split('/');

                if (strList[i][strList[i].Length - 1] == '/')
                {
                    Console.WriteLine(strSplit[strSplit.Length - 2]);
                }
                else
                {
                    Console.WriteLine(strSplit[strSplit.Length - 1]);
                }
            }

            /*string str = "https://www.reddit.com/r/funny/";
            string[] strSplit = str.Split('/');
            Console.WriteLine(strSplit[strSplit.Length - 2]);*/
        }
    }
}