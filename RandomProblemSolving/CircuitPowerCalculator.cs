namespace RandomProblemSolving
{
    public class CircuitPowerCalculator
    {
        public static string CircuitPower(int voltage, int current)
        {
            int power = voltage * current;
            return ("Power: " + power);
        }
    }
}

/*
 // RUN
try
            {
                while (true)
                {
                    Console.Write("Voltage: ");
                    int voltage = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Current: ");
                    int current = Convert.ToInt32(Console.ReadLine());
                    string result = CircuitPowerCalculator.CircuitPower(voltage, current);
                    Console.WriteLine(result);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Missing Input or is not an Integer!");
                //throw;
            }
 
 */