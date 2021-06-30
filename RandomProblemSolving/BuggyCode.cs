using System;

namespace RandomProblemSolving
{
    public class BuggyCode
    {
        public void Greeting()
        {
            string[] nameList = new string[4];
            int i = 0;
            Console.WriteLine("Enter 4 Name:");
            for (i = 0; i < nameList.Length; i++)
            {
                Console.Write(i+1 + ". ");
                nameList[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine();

            for (i = 0; i < nameList.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(nameList[i]))
                {
                    Console.WriteLine("No input given.");
                }
                else
                {
                    if (nameList[i] == "Mubashir".ToLower())
                    {
                        Console.Write(i+1 + ". " + nameList[i] + ": ");
                        Console.WriteLine("Hello, my Love!");
                    }
                    else
                    {
                        Console.Write(i+1 + ". " + nameList[i] + ": ");
                        Console.WriteLine("Hello " + nameList[i] + '!');
                    }
                }
            }
        }
    }

    public class ConcatString
    {
        public static string ConcatName(string firstName, string lastName) => lastName + "," + firstName;
    }
}
