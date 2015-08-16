using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that would take as input a temperature in Centigrade Scale
//and convert it to Fahrenheit- the number can be integer or real.
//Use the formula: F=1.8C + 32
namespace CSExercises
{
    public class Ex08
    {
        public static void Main()
        {
            double f, c;
            Console.WriteLine("Please input the temperature (in Centigrade scale):");
            c = Convert.ToDouble(Console.ReadLine());
            f = 1.8 * c + 32;
            Console.WriteLine("the temperature in Fahrenheit is: " + f);
        }
    }
}
