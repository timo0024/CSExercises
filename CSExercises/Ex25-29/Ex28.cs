using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main()
        {
            int i, j, k=0;
            Console.WriteLine("***who is the prime?***");
            Console.WriteLine("Please enter an integer: ");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = 2; j < i; j++)
            {
                if ((i % j) == 0)
                {
                    k = 1;
                }
            }
            switch (k)
            {
                case 1:
                    Console.WriteLine("Not Prime");
                    break;
                case 0:
                    Console.WriteLine("Prime");
                    break;

            }
        }
    }
}
