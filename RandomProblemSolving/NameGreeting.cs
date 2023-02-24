using System;

namespace RandomProblemSolving
{
    public class NameGreeting
    {
        public string name;

        public string HelloName()
        {
            Console.Write("Type a name: ");
            name = Console.ReadLine();
            return "output: Hello " + name + '!';
        }
    }
}

/*
 // TRIGGER

NameGreeting name = new NameGreeting();
Console.WriteLine(name.HelloName());
 */