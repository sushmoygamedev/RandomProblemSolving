/*TRIGGER*/
/*string syllables = "mon-u-men-tal";
CountSyllables instence = new CountSyllables();
instence.syllables = syllables;
Console.WriteLine(instence.Syllable());*/
namespace RandomProblemSolving
{
    public class CountSyllables
    {
        public string syllables;
        public int Syllable()
        {
            //string[] splitDash = syllables.Split("-");
            int countSyllable = 1; //countSyllable = 0;
            /*foreach(string syllable in splitDash)
            {
                countSyllable++;
            }
            */
            for (int i = 0; i < syllables.Length; i++)
            {
                if (syllables[i] == '-')
                {
                    countSyllable++;
                }
            }
            return (countSyllable);
        }
    }
}