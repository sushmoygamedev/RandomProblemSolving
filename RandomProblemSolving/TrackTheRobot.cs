using System;

namespace RandomProblemSolving
{
    public class TrackTheRobot
    {
        public static string TrackRobot()
        {
            string[] cords = new string[] { "right 10", "up 50", "left 30", "down 10" }; // this are instruction
            //int x = 0, y = 0; // this is final position indicated by x and y cordinate
            int[] axis = new int[] { 0, 0 }; // axis[0] = x and axis[1] = y
            int[] ints = new int[cords.Length];

            Console.WriteLine("Instruction:");
            for (int i = 0; i < cords.Length; i++)
            {
                #region Substring way
                // solving with Substring
                /*int space = cords[i].IndexOf(' ');
                ints[i] = Convert.ToInt32(cords[i].Substring(space + 1));*/

                //Console.WriteLine(cords[i].Substring(0, space)); // cords[i] = right 10, Substring 0 -> space = right,up,left,down
                //Console.WriteLine(cords[i].Substring(space + 1)); // Substring space + 1 = 10,50,30,10;

                // Substring switch state
                /*switch (cords[i].Substring(0, space))
                {
                    case "right":
                        int right = ints[i];
                        axis[0] += right;
                        Console.WriteLine(cords[i].Substring(0, space) + ": " + right);
                        break;
                    case "left":
                        int left = ints[i];
                        axis[0] -= left;
                        Console.WriteLine(cords[i].Substring(0, space) + ": " + left);
                        break;
                    case "up":
                        int up = ints[i];
                        axis[1] += up;
                        Console.WriteLine(cords[i].Substring(0, space) + ": " + up);
                        break;
                    case "down":
                        int down = ints[i];
                        axis[1] -= down;
                        Console.WriteLine(cords[i].Substring(0, space) + ": " + down);
                        break;
                }*/

                // Substring if logic
                /*if (cords[i].Substring(0, space) == "right")
                {
                    int right = ints[i];
                    axis[0] += right;
                    Console.WriteLine(cords[i].Substring(0, space) + ": " + right);
                }
                if (cords[i].Substring(0, space) == "left")
                {
                    int left = ints[i];
                    axis[0] -= left;
                    Console.WriteLine(cords[i].Substring(0, space) + ": " + left);
                }
                if (cords[i].Substring(0, space) == "up")
                {
                    int up = ints[i];
                    axis[1] += up;
                    Console.WriteLine(cords[i].Substring(0, space) + ": " + up);
                }
                if (cords[i].Substring(0, space) == "down")
                {
                    int down = ints[i];
                    axis[1] -= down;
                    Console.WriteLine(cords[i].Substring(0, space) + ": " + down);
                }*/
                #endregion

                #region Split way
                string cord = cords[i];
                string[] cordSplit = cord.Split(' ');
                ints[i] = int.Parse(cordSplit[1]);
                for (int j = 0; j < cordSplit.Length; j++)
                {
                    //ints[i] = int.Parse(cordSplit[j+=1]);
                    //Console.WriteLine(ints[i]);
                    //Console.WriteLine(cordSplit[j]);
                    switch (cordSplit[j])
                    {
                        case "right":
                            int right = ints[i]; // ints[i] == int.Parse(cordSplit[j+1]) but have to convert first
                            axis[0] += right;
                            Console.WriteLine(cordSplit[j] + ": " + right);
                            break;
                        case "left":
                            int left = ints[i]; // it's better to keep it short
                            axis[0] -= left;
                            Console.WriteLine(cordSplit[j] + ": " + left);
                            break;
                        case "up":
                            int up = ints[i];
                            axis[1] += up;
                            Console.WriteLine(cordSplit[j] + ": " + up);
                            break;
                        case "down":
                            int down = ints[i];
                            axis[1] -= down;
                            Console.WriteLine(cordSplit[j] + ": " + down);
                            break;
                    }
                }
                #endregion
            }

            //Console.WriteLine("x: " + x + "\ny: " + y);
            return ("\nFinal Position: [" + axis[0] + ", " + axis[1] + "]");
            // the problem already solved, just experimenting something :) no luck on experiment skip the rest after solving :(
        }
    }
}

//Console.WriteLine(TrackTheRobot.TrackRobot()); 