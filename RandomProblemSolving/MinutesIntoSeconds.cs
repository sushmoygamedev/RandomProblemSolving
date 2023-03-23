using System;

namespace RandomProblemSolving
{
    public class MinutesIntoSeconds
    {
        int minutes, result;

        public void Seconds()
        {
            try
            {
                Console.Write("Input Minutes: ");
                minutes = Convert.ToInt32(Console.ReadLine());
                int seconds = 60;
                result = minutes * seconds;
                Console.WriteLine("Minutes: {0} \nSeconds: {1} \nMinutes * Seconds = Result \n{0} * {1} = {2} \nResult: {2}", minutes, seconds, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("Given Minutes Not An Integer!");
                //throw;
            }
        }
    }
}

/*
// RUN
MinutesIntoSeconds instance = new MinutesIntoSeconds();
instance.Seconds();
 */