using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main()
        {
            int tv, dvd, mp3, cost1, cost11;
            double price1, price;
            Console.WriteLine("****Welcome to Electronics Pte Ltd.****");
            Console.Write("Enter quantity for TV: ");
            tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            mp3 = Convert.ToInt32(Console.ReadLine());
            cost1 = tv * 900 + dvd * 500 + mp3 * 700;
            cost11 = tv * 900 + dvd * 500;
            if (cost1 > 5000 && cost1 < 10000)
            {
                price1 = Convert.ToDouble(cost11 * (1 - 0.1));
            }
            else if (cost1 >= 10000)
            {
                price1 = Convert.ToDouble(cost11 * (1 - 0.15));
            }
            else
                price1 = Convert.ToDouble(cost1);
            price = price1 + Convert.ToDouble(mp3*700);
            Console.WriteLine("Total price for this order is $" + price);
        }
    }
}