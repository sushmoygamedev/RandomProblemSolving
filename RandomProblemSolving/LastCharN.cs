using System;
namespace RandomProblemSolving
{
    public class LastCharN
    {
        public void isCharN(string[] nameList)
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                if (nameList[i][nameList[i].Length - 1] == 'n')
                {
                    Console.Write(nameList[i] + ": ");
                    Console.WriteLine(true);
                }
                else
                {
                    Console.Write(nameList[i] + ": ");
                    Console.WriteLine(false);
                }
            }
        }
    }
}
