using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main()
        {
            int i;
            double[] sales = new double[12];
            double max, min, sale, sum = 0, average;
            Console.WriteLine("**********Welcome***********");
            for (i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month " + i + ": ");
                sale = Convert.ToDouble(Console.ReadLine());
                sales[i] = sale;
            }
            max = sales[0];
            min = sales[0];
            for (i = 0; i < 12; i++)
            {
                if (sales[i] >= max)
                {
                    max = sales[i];
                }
                else if(sales[i]<=min)
                {
                    min = sales[i];
                }
            }
            for (i = 0; i < 12; i++)
            {
                sum = sum + sales[i];
            }
            average = Convert.ToDouble(sum / 12.0);
            Console.WriteLine( "Maximun Sales: " + max);
            Console.WriteLine("Minmum Sales: " + min);
            Console.WriteLine("Average Sales: {0:0.0##}",average);
        }

    }
}
