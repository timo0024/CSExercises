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
               
            /*int i, f, j, k;
            Console.Write("Please enter an integer number: ");
            i = Convert.ToInt32(Console.ReadLine());  
            for (j = i-1; j > 0; j--)
            {
                if ((i % j) == 0)
                {
                    Console.WriteLine(i + "'s factorial is " + j);
                }
            }*/
            //Ex25b

            int i, f, j, k;
            Console.Write("Please enter an integer number: ");
            i = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j < i; j++)
            {
                if ((i % j) == 0)
                {
                    Console.WriteLine(i + "'s factorial is " + j);
                }
            }

        }
    }
}
