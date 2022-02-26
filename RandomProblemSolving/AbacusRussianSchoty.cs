#region Test Case
/*string[] abacus = new string[]
{
                "---OOOOOOOOOO", "---OOOOOOOOOO", "OOOOOOOOO---O", "OOOOOOOO---OO", "OOOOOOOOO---O", "OO---OOOOOOOO", "OOOOOOOO---OO"
};
Console.WriteLine(AbacusRussianSchoty.BeadsCount(abacus));*/
#endregion
using System;

namespace RandomProblemSolving
{
    public class AbacusRussianSchoty
    {
        public static string BeadsCount(string[] abacus)
        {
            int[] beadCount = new int[abacus.Length];

            string beadCountResult = string.Empty;

            for (int i = 0; i < abacus.Length; i++)
            {
                for (int j = 0; j < abacus[i].Length; j++)
                {
                    if (abacus[i][j] == '-')
                    {
                        break;
                    }
                    else
                    {
                        beadCount[i]++;
                    }
                }
                beadCountResult += (beadCount[i]);
                Console.WriteLine(abacus[i] + " -> " + beadCount[i]);
            }
            return ("Result: " + beadCountResult.TrimStart('0'));
        }
    }
}