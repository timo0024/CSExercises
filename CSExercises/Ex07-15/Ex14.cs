using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main()
        {
            double a, b, c, s, area;
            Console.WriteLine("Please input the lengths of three sides: ");
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());
            while (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("a,b,c should >0,please input again!");
                Console.Write("a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c: ");
                c = Convert.ToDouble(Console.ReadLine());
            }
            if (a + b > c && a + c > b && c + b > a)
            {
                s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("area = " + area);
            }
            else
                Console.WriteLine("sorry,it's not a triangle.");
        }
    }
}