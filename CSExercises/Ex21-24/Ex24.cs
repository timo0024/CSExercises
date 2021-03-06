using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main()
        {
            double N, G = 0;
            Console.Write("Please enter a number: ");
            N = Convert.ToDouble(Console.ReadLine());
            Random r = new Random();
            if (N < 1 || N > 0)
            {
                G = r.NextDouble();
            }
            else if(N >= 1)
            {
                 G = Convert.ToDouble(r.Next(1, Convert.ToInt32(N)+1)) +r.NextDouble();
            }
            /*           
            while ((G*G) != N)
            {
                G = (G + N / G) / 2;
            }*/
            while (Convert.ToDouble((G*G).ToString("0.00000")) != N)
            {
                G = (G + N / G) / 2;
            }
            Console.WriteLine(N + "'s square root is " + Convert.ToDouble(G.ToString("0.00000")));
        }
    }
}
