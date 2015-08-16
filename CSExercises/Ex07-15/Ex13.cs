using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main()
        {
            double distance, cost, ccost;
            Console.WriteLine("Wlecome to ABC Taxi Company!");
            Console.Write("Please input your distance(km):  ");
            distance = Convert.ToDouble(Console.ReadLine());
            cost = distance * 0.4 + 2.40;
            //  string ccost = cost.ToString("c");
            ccost = Math.Ceiling(cost);
            Console.WriteLine("****************************");
            Console.WriteLine("distance(km): " + distance);
            Console.Write("the cost(S$): ");
            Console.Write("{0:##.#0}", ccost);
        }
    }
}
