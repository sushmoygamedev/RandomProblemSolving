using System;

namespace RandomProblemSolving
{
    public class EmptyOrNull
    {
        public string str;

        public void isEmpty()
        {
            while(true)
            {
                Console.Write("Enter Some Text Or Leave It Blank: ");
                str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Input Is Empty: " + "\"" + true + "\"" + "\n");
                }
                else
                {
                    Console.WriteLine("Input Is Not Empty: " + "\"" + false + "\"" + "\n");
                }
            }
            /*string str = null;
            bool result = true;
            for(int i =0; i <= str.Length; i++)
            {
                if(str == "")
                {
                    result = true;
                } else
                {
                    result = false;
                }
            }
            Console.WriteLine(result);*/
        }
    }
}

/*
 // TRIGGER
EmptyOrNull test = new EmptyOrNull();
            test.isEmpty();
 */