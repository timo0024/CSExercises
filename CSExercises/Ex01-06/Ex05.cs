using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Slight modification to above : Write a program that takes a double precision number as input 
//and prits the square root of the number. The square root should be rounded to 3 decimal places. 
namespace CSExercises
{
    public class Ex05
    {
        public static void Main()
        {
            double i, j;
            Console.Write("Please intput a double precision number:   ");
            i = Convert.ToDouble(Console.ReadLine());
            j = Math.Sqrt(i);
            Console.WriteLine("\n" + i + "'s square root is  " + "{0:0.000}", j);
        }
    }
}
