using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main()
        {
            //Ex25a

           
            int i, j, sum=1;
            Console.Write("Please enter an integer number: ");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <=i; j++)
            {
                sum = sum * j;
            }
            Console.WriteLine(i + "'s factorial is " + sum);
            //Ex25b

            /*int i, j, sum=1;
            Console.Write("Please enter an integer number: ");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = i; j > 1; j--)
            {
                sum = sum * j;
            }
            Console.WriteLine(i + "'s factorial is " + sum);*/
        }
    }
}
