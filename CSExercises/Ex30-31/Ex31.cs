using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main()
        {
            int i=0,  j, n;
            for (n = 1; n <= 1000; n++)
            {
                int sum = 1;
                for (j = 2; j < n; j++)
                {
                    if ((n % j) == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == n)
                {
                    i++;
                    Console.WriteLine("Perfect Number(" + i +"): " + n);
                }
            }
        }
    }
    
}
