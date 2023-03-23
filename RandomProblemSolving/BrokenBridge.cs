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

/*
 // TRIGGER
 while(true)
            {
                Console.Write("Make a bridge or Break it: ");
                string bridge = Console.ReadLine();
                if (string.IsNullOrEmpty(bridge) )
                {
                    break;
                }
                else
                {
                    //Console.Write("\n" + bridge + ": ");
                    Console.WriteLine("Flag: " + BrokenBridge.IsBridgeSafe(bridge));
                }
            }
 */