/*TRIGGER CODE*/
/*Console.Write("INSERT DIRECTION: ");
string directions = Console.ReadLine();
string dToUpper = directions.ToUpper();
BackToHome instence = new BackToHome();
Console.WriteLine(instence.Home(dToUpper));*/
using System;

namespace RandomProblemSolving
{
    public class BackToHome
    {
        public bool Home(string directions)
        {
            int x = 0, y = 0;
            bool result = true;

            for (int i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                    default:
                        Console.WriteLine("Some Case Not Matched!");
                        break;
                }
                Console.WriteLine("x: " + x);
                Console.WriteLine("y: " + y);
                Console.WriteLine();
            }

            if (x == 0 && y == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
