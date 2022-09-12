using System;

namespace RandomProblemSolving
{
    public class AWeekAfter
    {
        public static string SevenDays()
        {
            Console.Write("Enter Date [dd/MM/yyyy] Format: ");
            string date = Console.ReadLine(); // day month year = dd/MM/yyyy
            string[] dateSplit = date.Split('/');
            int[] dateInt = new int[dateSplit.Length]; // to store string value into this array as integer

            for (int i = 0; i < dateSplit.Length; i++)
            {
                dateInt[i] = int.Parse(dateSplit[i]); // convert string data to integer
                                                      // dateInt[i]
                                                      // dateInt[0] = day
                                                      // dateInt[1] = month
                                                      // dateInt[2] = year
            }

            int day = dateInt[0];
            int month = dateInt[1];
            int year = dateInt[2];

            // hard coded format
            // DateTime dateTime = new DateTime(dateInt[2], dateInt[1], dateInt[0]); // year month day = yyyy/MM/dd
            // simplified way
            DateTime dateTime = new DateTime(year, month, day); // year month day = yyyy/MM/dd
            string aWeekAfter = dateTime.AddDays(7).ToString("dd/MM/yyyy");

            return ("Input Date: " + date + "\n" + "A Week After: " + aWeekAfter);
        }
    }
}

/*
// As DateTime class it take input as integer and return integer,
// if we input anyother type of data the program will throw error,
// which have to handle with condition or error exception handing way
// problem is solved here
Console.WriteLine(AWeekAfter.SevenDays());
 */