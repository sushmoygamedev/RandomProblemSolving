/*main method code*/
/*Console.Write("Insert Number1: ");
float num1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Insert Operator: ");

char op = Convert.ToChar(Console.ReadLine());
Console.Write("Insert Number2: ");
float num2 = Convert.ToSingle(Console.ReadLine());

StringOperator instence = new StringOperator();
Console.Write("Calc: ");
Console.WriteLine(instence.Calculate(num1, num2, op));*/
using System;

namespace RandomProblemSolving
{
    public class StringOperator
    {
        public float Calculate(float num1, float num2, char op)
        {
            {
                switch (op)
                {
                    case '+':
                        return (num1 + num2);
                    case '-':
                        return (num1 - num2);
                    case '*':
                        return (num1 * num2);
                    case '/':
                        return (num1 / num2);
                    case '%':
                        return (num1 % num2);
                    default:
                        Console.WriteLine("Operator Not Found!");
                        break;
                }
            }
            
            return Convert.ToSingle(null);

            /*if (op == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == '/')
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == '%')
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("No Operator Found");
            }*/

            /*if (op == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            if (op == '/')
            {
                Console.WriteLine(num1 / num2);
            }
            if (op == '%')
            {
                Console.WriteLine(num1 % num2);
            }*/
        }
    }
}
