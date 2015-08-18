using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that would request for your name and gender(M or F assume capital letter)
//and print a greeting like this: Good Morning Mr.Venkat
//where you entered Venkat for name and M for gender, use Mr.for males and Ms. for females.
namespace CSExercises
{
    public class Ex16
    {
        public static void Main()
        {
            string name, gender;
            Console.WriteLine("Please enter your name and gender:");
            Console.Write("name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("gender(M/F): ");
            gender = Convert.ToString(Console.ReadLine());
            while (gender != "M" && gender != "F")
            {
                Console.WriteLine("Please enter correct gender(M/F): ");
                gender = Convert.ToString(Console.ReadLine());
            }
            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
        }
    }
}