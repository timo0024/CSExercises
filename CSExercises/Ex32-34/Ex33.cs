using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sort 86 35 41 49 89 51 11 71 50 75 25 58 40 14 44 3 63 81 93 79 desceding
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] sort = new int[20] { 83, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i, j, k,temp;
            for (i = 0; i < 20; i++)
            {
                for (j = i+1; j < 20; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                        for (k = 0; k < sort.Length; k++)
                        {
                            Console.Write(sort[k] + " ");
                        }
                        Console.WriteLine("\n");
                    }

                }
 
            }
        }
    }
}
