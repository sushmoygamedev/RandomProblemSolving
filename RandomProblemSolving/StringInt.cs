using System;
namespace RandomProblemSolving
{
    public class StringInt
    {
        public void isInt()
        {
            Console.Write("Insert a number: ");
            string strNum = Console.ReadLine();
            int number = Convert.ToInt32(strNum);

            Console.WriteLine("stringNumber: " + strNum + " (" + strNum.GetType() + ")");
            Console.WriteLine("number: " + number + " (" + number.GetType() + ")");
        }
    }
}

/*
// TRIGGER
StringInt strTest = new StringInt();
strTest.isInt();
 */