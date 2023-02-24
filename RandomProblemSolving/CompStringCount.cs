namespace RandomProblemSolving
{
    public class CompStringCount
    {
        public string str1;
        public string str2;
        public bool comp()
        {
            if (str1.Length == str2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

/*
 // TRIGGER
string str1, str2;

            while(true)
            {
                Console.Write("First String: ");
                str1 = Console.ReadLine();
                Console.Write("Second String: ");
                str2 = Console.ReadLine();

                if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                {
                    Console.WriteLine("No Input Given!");
                    break;
                }
                else
                {
                    Console.Write("Result: ");
                    CompStringCount test = new CompStringCount();
                    test.str1 = str1;
                    test.str2 = str2;
                    Console.WriteLine(test.comp() + "\n");
                }
            }
 */