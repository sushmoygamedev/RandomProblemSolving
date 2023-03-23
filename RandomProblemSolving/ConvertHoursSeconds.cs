namespace RandomProblemSolving
{
    public class ConvertHoursSeconds
    {
        public static int howManySeconds(int hours)
        {
            int minutesAndSeconds = 60;
            int seconds = hours * minutesAndSeconds * minutesAndSeconds;
            return seconds;
        }
    }
}

/*
 // RUN
Console.Write("Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int seconds = ConvertHoursSeconds.howManySeconds(hours);
            Console.WriteLine("{0} hours = {1} seconds", hours, seconds);
 */