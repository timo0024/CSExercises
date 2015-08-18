using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main()
        {
            double distance, cost;
            Console.WriteLine("*********Welcome to ABC Taxi Company*********");
            Console.Write("Please enter your distance(km): ");
            distance = Convert.ToDouble(Console.ReadLine());
            if (distance < 0)
            {
                Console.WriteLine("wrong distance");
            }
            else if (distance == 0)
            {
                Console.WriteLine("FREE");
            }
            else if (distance <= 0.5)
            {
                Console.WriteLine("Your cost is $2.4.");
            }
            else if (distance <= 9)
            {
                cost = 2.4 + (Math.Ceiling(distance * 10) - 5) * 0.04;
                Console.WriteLine("Your cost is $" + cost + ".");
            }
            else
            {
                cost = 2.4 + 8.5 * 0.4 + (Math.Ceiling(distance * 10) - 90) * 0.05;
                Console.WriteLine("Your cost is $" + cost + ".");
            }

        }
    }
}