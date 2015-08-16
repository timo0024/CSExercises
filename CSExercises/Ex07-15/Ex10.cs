using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads the (x,y)coordinates of two points. You can adk the user to enter four real values(do it in the ouder of x1,y1,x2andy2).
//Compute the distance between the two pionts using the formula:
//Distance = Square Root of[ (x2-x1)^2 + (y2-y1)^2]
namespace CSExercises
{
    public class Ex10
    {
        public static void Main()
        {
            double distance, x1, x2, y1, y2, x, y;
            Console.WriteLine("Please input 4 real values blow :");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            x = (x2 - x1) * (x2 - x1);
            y = (y2 - y1) * (y2 - y1);
            distance = Math.Sqrt(x + y);
            Console.WriteLine("distance = " + distance);
        }
    }
}
