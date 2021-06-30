/*TRIGGER*/
/*
string[] wordList = new string[] { "a", "b", "c", "d", "e", "f" };
string findIndex = "f";

Console.WriteLine(FindWordIndex.FindIndex(wordList, findIndex)); 
*/
namespace RandomProblemSolving
{
    public class FindWordIndex
    {
        public static string FindIndex(string[] wordList, string findIndexOf)
        {
            string result = "";
            for (int i = 0; i < wordList.Length; i++)
            {
                /*Console.WriteLine(wordList[i] + ": " + i);*/

                if (wordList[i] == findIndexOf)
                {
                    result = (wordList[i] + ": " + i);
                    break;
                }
                else
                {
                    result = "Index Not Found!";
                }
            }
            return result;
            /*int wordIndex = Array.IndexOf(wordList, findIndex);*/
            /*Console.WriteLine(wordIndex);*/
        }
    }
}
