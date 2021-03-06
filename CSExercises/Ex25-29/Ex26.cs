using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main()
        {
            double inverse, root, square;
            Console.WriteLine("\tNO\t\tINVERSE\t\tSQUARE ROOT\t   SQUARE");
            Console.WriteLine("     --------------------------------------------------------------------");
            for (double i = 1.0; i <= 10; i++)
            {
                inverse = 1 / i;
                root = Math.Sqrt(i);
                square = i * i;
                Console.WriteLine("\t{0:0.0##}\t\t{1:0.0##}\t\t {2:0.0##}\t\t  {3:0.0##}", i, inverse, root, square);
            }
        }
    }
}
