using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes an iteger as iput and prints the square of that number
namespace CSExercises
{
    public class Ex02
    {
        public static void Main()
        {
            int i, j;
            Console.Write("Please intput an integer:   ");
            i = Convert.ToInt32(Console.ReadLine());
            j = i * i;
            Console.WriteLine("\n" + i + "'s square is  " + j);
        }
    }
}
