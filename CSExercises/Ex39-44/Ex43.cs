using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
            public static void Main(string[] args)
            {
                int i, j;
                string[] hex;
                Console.WriteLine("*** return hexadecimal ***");
                for(i=1;i<=100;i++)
                {
                    Console.Write("\t" + i + " = ");
                    hex = Hex(i);
                    for (j = 0; j < hex.Length; j++)
                        Console.Write(hex[j]);
                    Console.WriteLine("\n");
                }
            // if enter any integer 
               /* int i;
                string[] hex;
                Console.WriteLine("Please enter an integer; ");
                i = Convert.ToInt32(Console.ReadLine());
                hex = Hex(i);
                Console.Write(i + " = ");
                for (i = 0; i < hex.Length; i++)
                        Console.Write(hex[i]);*/

                
            }
            public static string[] Hex(int k)
            {
                int i, j,n;
                double m;
                n = k;
                m = Math.Floor(Convert.ToDouble(n / 16));
                for (i = 1; m >= 1; i++)
                {
                    m = m/16;
                }

                m = Math.Floor(Convert.ToDouble(n / 16));
                double[] p = new double[i];
                string[] hexa = new string[i];
                j = i - 1;

                p[j] = k % 16;
                for (; j >0; j--)
                {
                    if (m >= 16)
                    {
                        p[j - 1] = m % 16;
                        m = Math.Floor(Convert.ToDouble(m / 16));                   
                    }
                    else
                       p[j - 1] = m;
                }

                for (j = 0; j < i ; j++)
                {
                if (p[j] == 10)
                    hexa[j] = "A";
                else if (p[j] == 11)
                    hexa[j] = "B";
                else if (p[j] == 12)
                    hexa[j] = "C";
                else if (p[j] == 13)
                    hexa[j] = "D";
                else if (p[j] == 14)
                    hexa[j] = "E";
                else if (p[j] == 15)
                    hexa[j] = "F";
                else
                    hexa[j] = Convert.ToString(p[j]);
                }

                return hexa;
            }
    }
}
