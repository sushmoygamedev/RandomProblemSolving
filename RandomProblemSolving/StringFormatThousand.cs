// TRIGGER
/*int number = 1000000;
Console.WriteLine(StringFormatThousand.ThousandComma(number));*/
namespace RandomProblemSolving
{
    public class StringFormatThousand
    {
        public static string ThousandComma(int number)
        {
            string stringFormat = string.Format("{0:n0}", number);
            //string stringFormat = string.Format("{0:n}", number);
            //string stringFormat = number.ToString("N0");
            //string stringFormat = number.ToString("N2");
            //string stringFormat = number.ToString("#,##0");
            //string stringFormat = string.Format("{0:#,##0.##}", number);
            //string stringFormat = string.Format("{0:#,##0.00}", number);
            //string stringFormat = string.Format("{0:N2}", number);
            //string stringFormat = string.Format("{0:N1}", number);
            return stringFormat;
        }
    }
}