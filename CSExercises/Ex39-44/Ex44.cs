using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            int i=0;
            string m=s;
            m= m.Replace(Convert.ToString(c1), Convert.ToString(c2));               
            return m;
         }
        public static void Main(string[] args)
        {
            string n,m;
            char a, b;
            Console.WriteLine("Please enter string:");
            n = Console.ReadLine();
            Console.WriteLine("Please enter character1: ");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter character2: ");
            b = Convert.ToChar(Console.ReadLine());
            m = Substitute(n,a,b);
            Console.WriteLine("After substitute: ");
            Console.WriteLine(m);
        }
    }
}
