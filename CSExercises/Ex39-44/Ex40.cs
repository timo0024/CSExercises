using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("Please intput a double precision number:   ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}'s square root is {1:0.00}",i,SQT(i));
        }

        public static double SQT(int n)
        {
            double j,m;
            m = Convert.ToDouble(n);
            j = Math.Sqrt(m);
            return j;
        }
    }
}
