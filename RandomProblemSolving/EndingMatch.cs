/*TRIGGER CODE*/
/*Console.Write("Type first word: ");
string str1 = Console.ReadLine();
Console.Write("Type second word: ");
string str2 = Console.ReadLine();


*//*NOW TRY SOMTHING IN PROCIDURAL*//*
Console.Write("Result: ");
Console.WriteLine(EndingMatch.Check(str1, str2));
            


            *//*SIMPLEST WAY*/
            /*if (str1.EndsWith(str2))
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }*/
using System;

namespace RandomProblemSolving
{
    public class EndingMatch
    {
        public static bool LoopCheck(string str1, string str2)
        {
            bool result = true;
            for (int i = str1.Length; i > 0; i--)
            {
                if (str1[str1.Length - i] == str2[str2.Length - i])
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return (result);
        }
        public static bool Check(string str1, string str2)
        {
            /*bool result = true;*/
            if (str1.Length <= str2.Length)
            {
                return EndingMatch.LoopCheck(str1, str2);
                /*for (int i = str1.Length; i > 0; i--)
                {
                    if (str1[str1.Length - i] == str2[str2.Length - i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                Console.WriteLine(result);*/
            }
            else
            {
                return EndingMatch.LoopCheck(str2, str1);
                /*for (int i = str2.Length; i > 0; i--)
                {
                    if (str1[str1.Length - i] == str2[str2.Length - i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                Console.WriteLine(result);*/
            }
            return Convert.ToBoolean(null);
        }
    }
}
/*SOME OTHER SOLUTIONS*/
/*string str1 = "samurai";
string str2 = "rai";
string strReverse = string.Empty;
bool flag = false;

if (str1.Length > str2.Length)
{
    for (int i = str2.Length; i > 0; i--)
    {
        strReverse += str1[str1.Length - i];
    }
    if (strReverse == str2)
    {
        flag = true;
    }
    Console.WriteLine(flag);
}
else
{
    for (int i = str1.Length; i > 0; i--)
    {
        strReverse += str2[str2.Length - i];
    }
    if (strReverse == str1)
    {
        flag = true;
    }
    Console.WriteLine(flag);
}*/

/*
if (str1.Length < str2.Length)
{
    for (int i = str1.Length; i > 0; i--)
    {
        //Console.WriteLine(str1[str1.Length - i]);

        if (str1[str1.Length - i] == str2[str2.Length - i])
        {
            flag = true;

        }
        else
        {
            flag = false;
            break;
        }
    }
}
else
{
    for (int i = str2.Length; i > 0; i--)
    {
        //Console.WriteLine(str1[str1.Length - i]);

        if (str1[str1.Length - i] == str2[str2.Length - i])
        {
            flag = true;

        }
        else
        {
            flag = false;
            break;
        }
    }
}
Console.WriteLine(flag);*/