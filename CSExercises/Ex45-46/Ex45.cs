 using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            double i,j;
            Console.WriteLine("Enter the amount: ");
            i = Convert.ToDouble(Console.ReadLine());
            j = i * 100;
            while (j % 5 != 0)
            {
                Console.WriteLine(i + "is not available,Please enter again");
                i = Convert.ToDouble(Console.ReadLine());
                j = i * 100;
            }
            Dispense(j);
        }
        public static void Dispense(double n)
        {
            int m;
            double i, j, k, p, q;
            i = Math.Floor(n / 100);
            j = Math.Floor((n - i * 100) / 50);
            k = n - i * 100 - j * 50;
            k = Math.Floor(k / 20);
            p = n - i * 100 - j * 50 - k * 20;
            p = Math.Floor(p / 10);
            q = n - i * 100 - j * 50 - k * 20 - p * 10;
            q = Math.Floor(q / 5);
            for (m = 0; m < i; m++)
            {
                Console.WriteLine("100c");
            }
            for (m = 0; m < j; m++)
            {
                Console.WriteLine("50c");
            }
            for (m = 0; m < k; m++)
            {
                Console.WriteLine("20c");
            }
            for (m = 0; m < p; m++)
            {
                Console.WriteLine("10c");
            }
            for (m = 0; m < q; m++)
            {
                Console.WriteLine("5c");
            }
        }
    }
}
