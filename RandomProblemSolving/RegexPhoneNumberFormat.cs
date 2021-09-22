// TRIGGER
/*string[] phoneNumberList = new string[]
            {
                "(123) 456-7890",
                "1111)555 2345",
                "098) 123 4567",
                "(519) 505-6498",
                "abc(123) 456-7890abc",
            };

RegexPhoneNumberFormat instance = new RegexPhoneNumberFormat();
instance.FormatNumber(phoneNumberList);

            //RegexPhoneNumberFormat.FormatNumber(phoneNumberList);*/

using System;
using System.Text.RegularExpressions;

namespace RandomProblemSolving
{
    public class RegexPhoneNumberFormat
    {
        public void FormatNumber(string[] phoneNumberList)
        {
            // \([0-9]+\) [0-9]+-[0-9]+ // this pattern is not accurate
            // ^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$ // this pattern is explanatory
            // ^\(\d{3}\) \d{3}-\d{4}$ // this patter is simplified

            //string phoneNumber = "(123) 456-7890";
            Regex pattern = new Regex(@"^\(\d{3}\) \d{3}-\d{4}$");

            for (int i = 0; i < phoneNumberList.Length; i++)
            {
                if (pattern.IsMatch(phoneNumberList[i]))
                {
                    Console.WriteLine(phoneNumberList[i] + ": " + true);
                }
                else
                {
                    Console.WriteLine(phoneNumberList[i] + ": " + false);
                }
            }

            /*if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/
        }
    }
}