using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main()
        {
            int a, b, a1, b1, c, x, lcm;
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            a1 = a;
            b1 = b;
            while (a1 != b1)
            {
                if (a1 > b1)
                {
                    c = a1 - b1;
                    a1 = c;
                }
                else
                {
                    c = b1 - a1;
                    b1 = c;
                }
            }
            x = a1;
            lcm = (a * b) / x;
            Console.WriteLine("HCF: " + x);
            Console.WriteLine("LCM: " + lcm);
        }
    }
}
