using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Take a program that takes an integer as input and prints the square root of that number.
//(Do you face ay issues on this ?If yes, how wold you resolve it?)
//answer: no issue,but need to pay attension in int and double
namespace CSExercises
{
    public class Ex06
    {
        public static void Main()
        {
            int i;
            double j;
            Console.Write("Please intput an integer:   ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToDouble(Math.Sqrt(i));
            Console.WriteLine("\n" + i + "'s square is  " + j);
        }
    }
}
