using System;

namespace RandomProblemSolving
{
    public class BasketballPoints
    {
        public int Points(int twoPointers, int threePointers)
        {
            int twoPointersMul = 2 * twoPointers;
            int threePointersMul = 3 * threePointers;

            int result = twoPointersMul + threePointersMul;
            Console.WriteLine("result: " + result);

            return result;
        }
    }
}

/*
// RUN
Console.Write("Two Pointers: ");
int twoPointers = Convert.ToInt32(Console.ReadLine());
Console.Write("Three Pointers: ");
int threePointers = Convert.ToInt32(Console.ReadLine());

BasketballPoints instance = new BasketballPoints();
instance.Points(twoPointers, threePointers);*/