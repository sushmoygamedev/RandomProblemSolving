namespace RandomProblemSolving
{
    public class ConFirstLast
    {
        public string FirstLast(string str)
        {
            char strFirst = str[0];
            char strLast = str[str.Length - 1];
            return (str + ": " + strFirst + "" + strLast);
            /*return (str + ": " + Convert.ToString(strFirst) + Convert.ToString(strLast));*/

            /*string name = "some";
            char[] chars = new char[] { name[0], name[name.Length - 1], name[2] };
            //name = new string(chars);
            Console.WriteLine(chars);*/
        }
    }
}
