using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main()
        {
            int i=0, j, n;
            Console.WriteLine("from 5 to 10000");
            for (n = 5; n <= 10000; n = n + 2)
            {
                int k = 0;
                for (j = 2; j < n; j++)
                {
                    if ((n % j) == 0)
                    {
                        k = 1;
                    }
                }
                if (k == 0)
                {
                    i++;
                    Console.WriteLine("prime number(" + i + ") " + n);
                }
            }

        }
    }
}
