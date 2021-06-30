namespace RandomProblemSolving
{
    public class BrokenBridge
    {
       public static bool IsBridgeSafe(string bridge)
        {
            bool broken = true;

            for (int i = 0; i < bridge.Length; i++)
            {
                if (bridge[i] == ' ')
                {
                    broken = false;
                    break;
                }
                else
                {
                    broken = true;
                }
            }
            return broken;
        }
    }
}
