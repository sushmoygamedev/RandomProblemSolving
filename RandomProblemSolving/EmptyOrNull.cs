using System;

namespace RandomProblemSolving
{
    public class EmptyOrNull
    {
        public string str = Console.ReadLine();

        public void isEmpty()
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
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
