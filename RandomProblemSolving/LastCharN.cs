using System;
namespace RandomProblemSolving
{
    public class LastCharN
    {
        public void isCharN(string[] nameList)
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                if (nameList[i][nameList[i].Length - 1] == 'n')
                {
                    Console.Write(i + 1 + ". " + nameList[i] + ": ");
                    Console.WriteLine(true);
                }
                else
                {
                    Console.Write(i + 1 + ". " + nameList[i] + ": ");
                    Console.WriteLine(false);
                }
            }
        }
    }
}

/*
 // RUN
 Console.WriteLine("Insert 10 Name:");
            string[] nameList = new string[10];
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                nameList[i] = Console.ReadLine();
            }

            Console.WriteLine("\nResults:");
            LastCharN names = new LastCharN();
            names.isCharN(nameList);
 */