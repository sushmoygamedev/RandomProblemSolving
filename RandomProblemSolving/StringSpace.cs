using System;

namespace RandomProblemSolving
{
    public class StringSpace
    {
        public string testStr = "", yesNo;
        public bool hasSpace = true;

        public bool HasSpaceIn()
        {
            //string yesNo = "";
            foreach (char letter in testStr)
            {
                if (letter == ' ')
                {
                    hasSpace = true;
                    yesNo = ("Has");
                    break;
                }
                else
                {
                    hasSpace = false;
                    yesNo = ("No");
                }
            }

            Console.Write(yesNo);
            return hasSpace;
        }
    }
}

/*
 // RUN
StringSpace test1 = new StringSpace();

            while (true)
            {
                Console.Write("Input: ");
                test1.testStr = Console.ReadLine();

                if (string.IsNullOrEmpty(test1.testStr))
                {
                    Console.WriteLine("Missing Input!");
                    break;
                }
                else
                {
                    Console.WriteLine(" Spaces: " + test1.HasSpaceIn());
                }
            }
 */