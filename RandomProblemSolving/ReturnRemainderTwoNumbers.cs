namespace RandomProblemSolving
{
    public class ReturnRemainderTwoNumbers
    {
        public int Remainder(int x, int y)
        {
            int remainder = x % y;
            return remainder;
        }
    }
}

/*
 // RUN
Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            ReturnRemainderTwoNumbers instance = new ReturnRemainderTwoNumbers();
            int result = instance.Remainder(x, y);

            Console.WriteLine("x % y = remainder \n{0} % {1} = {2}", x, y, result);
 */