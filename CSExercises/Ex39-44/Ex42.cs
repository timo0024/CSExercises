using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int j;
            if (s1.Length < s2.Length)
                return -1;
            else
            {
                for (j = 0; j <= s1.Length - s2.Length; j++)
                {
                    if (s1.Substring(j, s2.Length) == s2)
                    {
                        return j+1;
                    }
                }
                    return -1;
            }
        }
        public static void Main(string[] args)
        {
            string n, m;
            Console.WriteLine("Please enter string1:");
            n = Console.ReadLine();
            Console.WriteLine("Please enter string2: ");
            m = Console.ReadLine();
            if (FindWord(n, m)!=-1)
            {
                Console.WriteLine("* Occur! Start at No." + FindWord(n,m) + " position in s1*");
            }
            else
                Console.WriteLine("* Not Occur *");
        }
    }
}
