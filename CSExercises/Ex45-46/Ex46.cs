using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] n = new int[50];
            int[] sum = new int[10];
            int i, j;
            Random r = new Random();
            for (i = 0; i < 10; i++)
            {
                sum[i] = 0;
            }
            for (i = 0; i < 50; i++)
            {
                int num=r.Next(0,10);
                n[i] = num;
            }
            for (i = 0; i < 50; i++)
            {
                switch (n[i])
                {
                    case 0:
                        sum[0]++;
                        break;
                    case 1:
                        sum[1]++;
                        break;
                    case 2:
                        sum[2]++;
                        break;
                    case 3:
                        sum[3]++;
                        break;
                    case 4:
                        sum[4]++;
                        break;
                    case 5:
                        sum[5]++;
                        break;
                    case 6:
                        sum[6]++;
                        break;
                    case 7:
                        sum[7]++;
                        break;
                    case 8:
                        sum[8]++;
                        break;
                    case 9:
                        sum[9]++;
                        break;
                }
            }
            Console.WriteLine("Number\tCount\tNumber");
            for (i = 0; i < 10; i++)
            {
                Console.Write("  " +i + "\t  " + sum[i] +"\t  " + i +"\t");
                for (j = 0; j < sum[i]; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            

            /*int[] n = new int[50];
            int[] sum = new int[11];
            int i, j;
            Random r = new Random();
            for (i = 0; i < 11; i++)
            {
                sum[i] = 0;
            }
            for (i = 0; i < 50; i++)
            {
                int num = r.Next(-5, 6);
                n[i] = num;
            }
            for (i = 0; i < 50; i++)
            {
                switch (n[i])
                {
                    case -5:
                        sum[0]++;
                        break;
                    case -4:
                        sum[1]++;
                        break;
                    case -3:
                        sum[2]++;
                        break;
                    case -2:
                        sum[3]++;
                        break;
                    case -1:
                        sum[4]++;
                        break;
                    case 0:
                        sum[5]++;
                        break;
                    case 1:
                        sum[6]++;
                        break;
                    case 2:
                        sum[7]++;
                        break;
                    case 3:
                        sum[8]++;
                        break;
                    case 4:
                        sum[9]++;
                        break;
                    case 5:
                        sum[10]++;
                        break;
                }
            }
            Console.WriteLine("Number\tCount\tNumber");
            for (i = 0; i < 11; i++)
            {
                Console.Write("  " + (i - 5) + "\t  " + sum[i] + "\t  " + (i - 5) + "\t");
                for (j = 0; j < sum[i]; j++)
                    Console.Write("*");
                Console.Write("\n");
            }*/
        }
    }
}
