using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main()
        {
            int i;
            Console.WriteLine("Let's find the lucky number!");
            Console.WriteLine("Please enter an integer: ");
            i = Convert.ToInt32(Console.ReadLine());
            while (i != 88)
            {
                Console.WriteLine("Please enter again: ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Lucky you...");
        }
    }
}
