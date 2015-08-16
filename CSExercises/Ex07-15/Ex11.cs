using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ABC Taxi Company has the following meter charges based on the kilometres travelled.
//Minimumfixed charge: $2.40
//In addition the fare would be conputed at 40cents per kilometre
//E.g If the distance traveled is 3.24km then the total fare is 2.40+3.24*0.4
//Write a program that reads the distance and calculate the total fare.Print out the output without any numver formatting
namespace CSExercises
{
    public class Ex11
    {
        public static void Main()
        {
            double distance, cost;
            Console.WriteLine("Wlecome to ABC Taxi Company!");
            Console.Write("Please input your distance(km):  ");
            distance = Convert.ToDouble(Console.ReadLine());
            cost = distance * 0.4 + 2.40;
            string ccost = cost.ToString("c");
            Console.WriteLine("****************************");
            Console.WriteLine("distance(km): " + distance);
            Console.WriteLine("the cost(S$): " + ccost);
        }
    }
}
