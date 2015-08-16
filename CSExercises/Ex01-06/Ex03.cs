using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes a double precision number as input and prints the square of that number
namespace CSExercises
{
    public class Ex03
    {
        public static void Main()
        {
            double i, j;
            Console.Write("Please intput an integer:   ");
            i = Convert.ToDouble(Console.ReadLine());
            j = i * i;
            Console.WriteLine("\n" + i + "'s square is  " + j);
        }
    }
}
