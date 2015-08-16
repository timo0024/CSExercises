using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that would request for your name and print a greeting like this:
//Good Morning Venkat
//where Venkat is the name you had input.
namespace CSExercises
{
    public class Ex01
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("Please input your name:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Good Morning  " + name);
        }
    }
}
