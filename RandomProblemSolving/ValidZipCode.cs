// TRIGGER
/*string zipCode = "90*05";
ValidZipCode instence = new ValidZipCode();
Console.WriteLine(instence.IsValidZip(zipCode));*/
using System;
using System.Linq;

namespace RandomProblemSolving
{
    public class ValidZipCode
    {
        public string IsValidZip(string zipCode)
        {
            bool isValid = false;

            for (int i = 0; i < zipCode.Length; i++)
            {
                if (zipCode.Length == 5 && zipCode.All(char.IsDigit))
                {
                    isValid = true;
                }
            }

            Console.WriteLine("Zip Code: " + zipCode);
            Console.WriteLine("Zip Code Length: " + zipCode.Length);
            return ("Valid or Not?: " + isValid);
        }
    }
}