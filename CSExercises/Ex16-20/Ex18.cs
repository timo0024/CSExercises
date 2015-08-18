using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main()
        {
            int mark;
            Console.WriteLine("********Welcome to search your grade!**********");
            Console.Write("Please enter your marks: ");
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("**Error**");
            }
            else if (mark <= 40)
            {
                Console.WriteLine("You scored " + mark + " marks which is F grade.");
            }
            else if (mark <= 59)
            {
                Console.WriteLine("You scored " + mark + " marks which is C grade.");
            }
            else if (mark <= 79)
            {
                Console.WriteLine("You scored " + mark + " marks which is B grade.");
            }
            else if (mark <= 100)
            {
                Console.WriteLine("You scored " + mark + " marks which is A grade.");
            }
        }
    }
}