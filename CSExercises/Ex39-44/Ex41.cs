using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string n, m;
            Console.WriteLine("Please enter string1:");
            n = Console.ReadLine();
            Console.WriteLine("Please enter string2: ");
            m = Console.ReadLine();
            if (InString(n, m))
            {
                Console.WriteLine("* Occur *");
            }
            else
                Console.WriteLine("* Not Occur *");
        }
        public static bool InString(string s1, string s2)
        {
            int j/*, flag = 0*/; 
            if (s1.Length < s2.Length)
                return false;
            else
            {
                /*for (j = 0; j <= s1.Length-s2.Length; j++)
                {
                    if (s1.Substring(j, s2.Length) == s2)
                    {
                        flag = 1;
                    }
                }*/
                for (j = 0; j <= s1.Length - s2.Length; j++)
                {
                    if (s1.Substring(j, s2.Length) == s2)
                    {
                        return true;
                    }
                }
                return false;
                /*if (flag == 1)
                    return true;
                else
                    return false;*/
            }
        }

    }
}
