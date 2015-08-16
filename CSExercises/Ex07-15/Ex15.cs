using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main()
        {
            double i, i1, i2, i3, i11, i22, i33, ii, j1, j2;
            Console.WriteLine("Let's find armstrong number!");
            Console.Write("Please input a 3-digit integer: ");
            i = Convert.ToInt32(Console.ReadLine());
            ii = i / 100;
            while (ii < 1)
            {
                Console.WriteLine("it's not a 3-digit integer,please input again.");
                Console.Write("i = ");
                i = Convert.ToInt32(Console.ReadLine());
                ii = i / 100;
            }
            j1 = i / 100;
            i1 = Math.Floor(j1);
            j2 = (i - i1 * 100) / 10;
            i2 = Math.Floor(j2);
            i3 = i - i1 * 100 - i2 * 10;
            i11 = i1 * i1 * i1;
            i22 = i2 * i2 * i2;
            i33 = i3 * i3 * i3;
            if (i == i11 + i22 + i33)
            {
                Console.WriteLine("Congratulations! " + i + " is an armstrong number!");
            }
            else
            {
                Console.WriteLine("Sorry, " + i + " is not an armstrong number.");
            }
        }
    }
}