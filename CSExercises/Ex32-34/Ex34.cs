using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] mark = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 }};
            int i, j;
            int[] rsum = new int[mark.GetLength(0)];
            int[] csum = new int[mark.GetLength(1)];
            double[] classaverage = new double[mark.GetLength(1)];
            double[] stavariance = new double[mark.GetLength(1)];
            double sum, allsum=0, allaverage;
            for (i = 0; i < mark.GetLength(0); i++) //class sum
            {
                rsum[i] = 0;
                for (j = 0; j < mark.GetLength(1); j++)
                {
                    rsum[i] = rsum[i] + mark[i, j];
                }
            }
            for (j = 0; j < mark.GetLength(1); j++) //student sum
            {
                csum[j] = 0;
                for (i = 0; i < mark.GetLength(0); i++)
                {
                    csum[j] = csum[j] + mark[i, j];
                }
            }
            for (i = 0; i < mark.GetLength(1); i++) //classaverage
            {
                classaverage[i] = Convert.ToDouble(csum[i] / (mark.GetLength(0)*1.0));
            }
            for (j = 0; j < mark.GetLength(1); j++) // deviation
            {
                sum = 0.0;
                for (i = 0; i < mark.GetLength(0); i++)
                {
                    sum = sum + (mark[i, j] - classaverage[j]) * (mark[i, j] - classaverage[j]);
                }
                stavariance[j] = Math.Sqrt(sum / (mark.GetLength(0) * 1.0));
            }
            for (i = 0; i < mark.GetLength(0); i++)
            {
                
                allsum = allsum + rsum[i];
            }
            allaverage = allsum / (mark.GetLength(0)*mark.GetLength(1) * 1.0);//allaverage

            Console.WriteLine("\tC1\tC2\tC3\tC4\ttotalmarks");

            for (i = 0; i < mark.GetLength(0); i++)
            {
                Console.Write("S" + (i+1) +"\t");
                for (j = 0; j < mark.GetLength(1); j++)
                {
                    Console.Write(mark[i, j] + "\t");
                }
                Console.Write(rsum[i]);
                Console.Write("\n");
            }
            Console.Write("CA\t");
            for (i = 0; i < mark.GetLength(1); i++)
            {
                Console.Write("{0:0.0}\t",classaverage[i]);
            }
            Console.Write("\nVAR\t");
            for (i = 0; i < mark.GetLength(1); i++)
            {
                Console.Write("{0:0.0}\t", stavariance[i]);
            }
            Console.Write("\nALLAV\t" + allaverage +"\n");


        }
    }
}