using System;

namespace RandomProblemSolving
{
    public static class CharAscii
    {
        public static void Ascii()
        {
            string chList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < chList.Length; i++)
            {
                Console.WriteLine(chList[i] + "= " + Convert.ToInt32(chList[i]));
            }

            Console.WriteLine();

            try
            {
                while (true)
                {
                    Console.Write("Insert a character: ");
                    char insertChar = Convert.ToChar(Console.ReadLine());
                    int CharInt = Convert.ToInt32(insertChar);
                    Console.WriteLine("Char: " + insertChar + " - " + CharInt);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not a char! It's a string. or Empty!");
            }
        }
    }
}
/*
 // RUN
 CharAscii.Ascii();
 */