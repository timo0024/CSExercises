using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes a double precision umber as input and prits the square toot of the number
namespace CSExercises
{
    public class Ex04
    {
        public static void Main()
        {
            double i, j;
            Console.Write("Please intput a double precision number:   ");
            i = Convert.ToDouble(Console.ReadLine());
            j = Math.Sqrt(i);
            Console.WriteLine("\n" + i + "'s square root is  " + j);
        }
    }
}
