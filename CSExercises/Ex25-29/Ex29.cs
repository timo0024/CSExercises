using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main()
        {
            int i, sum = 1, j;
            Console.WriteLine("*****Find the pefect number!*****");
            Console.WriteLine("Please enter an integer number: ");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = 2; j < i; j++)
            {
                if ((i % j) == 0)
                {
                    sum=sum+j;
                }
            }
            if (sum == i)
            {
                Console.WriteLine("Perfect Number");
            }
            else
                Console.WriteLine("Not Perfect Number");
        }
    }
}
