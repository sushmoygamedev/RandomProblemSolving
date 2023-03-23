namespace RandomProblemSolving
{
    public class TriangleArea
    {
        public static string triArea(float b, float h)
        {
            float area = (b * h) / 2f;
            return ("Area: " + area);
        }
    }
}

/*
 // RUN
try
            {
                while (true)
                {
                    Console.Write("Base: ");
                    float IBase = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Height: ");
                    float IHeight = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine(TriangleArea.triArea(IBase, IHeight));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input not an Integer!");
                //throw;
            }
 */