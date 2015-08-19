using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter an integer number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Factorial(n);
        }
        public static void Factorial(int n)
        {
            int  j, sum = 1;
            for (j = 1; j <= n; j++)
            {
                sum = sum * j;
            }
            Console.WriteLine(n + "'s factorial is " + sum);
        }

    }
}
