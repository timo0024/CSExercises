using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main()
        {
            //Ex27a
            /*
            int x, y;
            Console.WriteLine("\t\t X\t\t\t Y");
            Console.WriteLine("\t------------------------------------------");
            for (x = -5; x <= 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("\t\t {0:0.0}\t\t\t{1:0.0}",x,y);
            }
            */

            //Ex27b
            int x, y, i;
            for (x = 1; x <= 20; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.Write("(x=" + x + ")");
                for (i = 0; i <= y; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
