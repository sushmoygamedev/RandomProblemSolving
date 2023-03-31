using System;

namespace RandomProblemSolving
{
    public class AreNumbersEqual
    {
        public void NumberEqual()
        {
            try
            {
                Console.Write("Enter NUM1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter NUM2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                bool isEqual = num1 == num2;

                if (isEqual)
                {
                    Console.WriteLine("It Is Equal = " + isEqual);
                }
                else
                {
                    Console.WriteLine("It Is Not Equal = " + isEqual);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }
    }
}

/*
 // RUN

AreNumbersEqual instance = new AreNumbersEqual();
            instance.NumberEqual();

            AreNumbersEqual instance2 = new AreNumbersEqual();
            instance2.NumberEqual();

            AreNumbersEqual instance3 = new AreNumbersEqual();
            instance3.NumberEqual();

            AreNumbersEqual instance4 = new AreNumbersEqual();
            instance4.NumberEqual();
 */