namespace RandomProblemSolving
{
    public class RevAndNot
    {       
        public string RevNum(int num)
        {
            string numStr = num.ToString();
            string revNum = string.Empty;

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                revNum += numStr[i];
            }

            return (revNum + numStr);
        }
    }
}

/*
// TEST
int num = 12344321;
RevAndNot instance = new RevAndNot();
Console.WriteLine(instance.RevNum(num));
*/