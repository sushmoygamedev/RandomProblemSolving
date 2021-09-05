// TRIGGER
/*string str = "applepotatopotatoes";
RegexPatterMatch.CountPotato(str);*/

using System;
using System.Text.RegularExpressions;

namespace RandomProblemSolving
{
    public class RegexPatterMatchCount
    {
        public static void CountPotato(string str)
        {
            Regex patter = new Regex("potato");

            Match match = patter.Match(str);
            if (patter.IsMatch(str))
            {
                Console.WriteLine(match);
            }
            else
            {
                Console.WriteLine("No match found!");
            }

            MatchCollection matchCol = patter.Matches(str);

            Console.WriteLine(matchCol.Count);

            for (int i = 0; i < matchCol.Count; i++)
            {
                Console.WriteLine(matchCol[i]);
            }
        }
    }
}