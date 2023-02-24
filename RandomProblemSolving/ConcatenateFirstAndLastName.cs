using System;

namespace RandomProblemSolving
{
    public class ConcatenateFirstAndLastName
    {
        public static string ConcatName(string firstName, string lastName)
        {
            return lastName + ", " + firstName;
        }

        public static void ConcatLastFirst()
        {
            while (true)
            {
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Nmae: ");
                string lastName = Console.ReadLine();

                if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Input Missing");
                    break;
                }
                else
                {
                    Console.WriteLine("Before: \"" + firstName + "\", \"" + lastName + "\"\n" + "After: " + ConcatName(firstName, lastName));
                }
            }
        }
    }
}

/*
 // TRIGGER
 ConcatenateFirstAndLastName.ConcatLastFirst();
 */