using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string s, d,b;
            Console.WriteLine("******Make Title Case*******");
            Console.WriteLine("Please enter a phrase/sentance");
            s = Console.ReadLine();
            char[] c = new char[s.Length];
            int i;
            d = s.Substring(0, 1);
            d=d.ToUpper();
            c[0]=Convert.ToChar(d);
            for (i = 1; i < s.Length; i++)
            {
                b = s.Substring(i, 1);
                if (i == s.Length - 1)
                {
                    d = b;
                }
                else
                    d = s.Substring(i + 1, 1);
                c[i] = Convert.ToChar(b);
                if (b == " " && d != " ")
                {
                    d = d.ToUpper();
                    c[i + 1] = Convert.ToChar(d);
                    i++;
                }          
            }
            for(i=0; i<s.Length;i++)
            Console.Write(c[i]);
        }
    }
}
