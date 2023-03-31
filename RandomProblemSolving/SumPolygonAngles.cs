using System;

namespace RandomProblemSolving
{
    public class SumPolygonAngles
    {
        public static int PolygonAngles()
        {
            int result = 0;
            try
            {
                Console.Write("Enter the Polygon Sides: ");
                int num = Convert.ToInt32(Console.ReadLine()); // n
                result = (num - 2) * 180;
                Console.WriteLine("result: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            return result;
        }
    }
}

/*
 // RUN
SumPolygonAngles.PolygonAngles();
 */