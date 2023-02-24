namespace RandomProblemSolving
{
    public class ReturnSomethingToMe
    {
        public string ReturnSomething(string str, string something = "something")
        {
            return "output: " + something + " " + str;
        }
    }
}

/*
 // TRIGGER

Console.Write("Type something: ");
ReturnSomethingToMe result = new ReturnSomethingToMe();
Console.WriteLine(result.ReturnSomething(Console.ReadLine()));
 */