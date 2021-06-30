namespace RandomProblemSolving
{
    public class StringSpace
    {
        public string testStr = "";
        public bool hasSpace = true;

        public bool HasSpaceIn()
        {
            foreach (char letter in testStr)
            {
                if (letter == ' ')
                {
                    hasSpace = true;
                    break;
                }
                else
                {
                    hasSpace = false;
                }
            }
            return hasSpace;
        }
    }
}
