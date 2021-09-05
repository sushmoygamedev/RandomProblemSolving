// TRIGGER
/*
 string str = "potatopotatopotatoorange";
            RegexAmountPotatoes.CountPotato(str);
 */
using System;
using System.Text.RegularExpressions;

namespace RandomProblemSolving
{
    public class RegexAmountPotatoes
    {
        public static void CountPotato(string str)
        {
            Regex pattern = new Regex("(potato)");

            Match match = pattern.Match(str); // It only show the first found word pattern from the string

            if (pattern.IsMatch(str)) // need sometime to test as boolean
            {
                Console.WriteLine(match);
            }
            else
            {
                Console.WriteLine("No matches found");
            }

            MatchCollection matchCol = pattern.Matches(str); // set of all matches occures with the pattern in the string

            Console.WriteLine(matchCol.Count);

            for (int i = 0; i < matchCol.Count; i++)
            {
                Console.WriteLine(matchCol[i]);
            }
        }
    }
}