using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //Ex35a
            /*string s,s1;
            int i,num=0;
            Console.WriteLine("*****find the vowels********");
            Console.WriteLine("Please enter a phrase");
            s = Console.ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                s1 = s.Substring(i, 1).ToLower();   
                if (s1 == "a" || s1 == "e" || s1 == "i" || s1 == "o" || s1 == "u")
                {
                    num++;
                }
            }
            Console.WriteLine("Total number of vowels: " + num);*/

            //Ex35b
            string s, s1;
            int i, numa = 0, nume = 0, numi = 0, numo = 0, numu = 0;
            Console.WriteLine("*****find the vowels********");
            Console.WriteLine("Please enter a phrase");
            s = Console.ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                s1 = s.Substring(i, 1).ToLower();
                switch (s1)
                {
                    case "a":
                        numa++;
                        break;
                    case "e":
                        nume++;
                        break;
                    case "i":
                        numi++;
                        break;
                    case "o":
                        numo++;
                        break;
                    case "u":
                        numu++;
                        break;
                }
            }
            Console.WriteLine("Number of a: " + numa);
            Console.WriteLine("Number of e: " + nume);
            Console.WriteLine("Number of i: " + numi);
            Console.WriteLine("Number of o: " + numo);
            Console.WriteLine("Number of u: " + numu);
        }
    }
}
