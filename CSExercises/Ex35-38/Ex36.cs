using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //Ex36a
            /*string s;
            int i, j, flag=0;
            double k;
            Console.WriteLine("******Palindrome or not*******");
            Console.WriteLine("Please enter a phrase");
            s = Console.ReadLine();
            k = Math.Floor(Convert.ToDouble(s.Length / 2.0));
            for (i = 0, j = s.Length - 1; i < k&& j > k; i++,j--)
            {
                    if (s.Substring(i, 1) != s.Substring(j, 1))
                    {
                        flag = 1;
                    }
            }
            if (flag == 1)
            {
                Console.WriteLine("Not Palindrome");
            }
            else
            {
                Console.WriteLine("Palindrome");
            }*/

            //Ex36b
            string s;
            int i, j, flag = 0;
            double k;
            Console.WriteLine("******Palindrome or not*******");
            Console.WriteLine("Please enter a phrase");
            s = Console.ReadLine();
            s = s.Replace(" ", "");
            s = s.Replace(".", "");
            s = s.Replace("?", "");
            s = s.Replace("!", "");
            s = s.ToLower();
            k = Math.Floor(Convert.ToDouble(s.Length / 2.0));
            for (i = 0, j = s.Length - 1; i < k && j > k; i++, j--)
            {
                if (s.Substring(i, 1) != s.Substring(j, 1))
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Not Palindrome");
            }
            else
            {
                Console.WriteLine("Palindrome");
            } 
        }
    }
}
