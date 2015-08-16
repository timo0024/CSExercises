using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that would take as input the value of x and calculate & output the value of y using the formula:
// y = 2 x^2 - 4x +3
namespace CSExercises
{
    public class Ex09
    {
        public static void Main()
        {
            double x, y;
            Console.WriteLine("*********calculate y************");
            Console.Write("the value of x: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("the value of y :" + y);
        }
    }
}
