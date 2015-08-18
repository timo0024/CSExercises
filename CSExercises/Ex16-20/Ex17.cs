using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that would request for your name,gender and age
//Good Morning Uncle Sam(input Sam,M,45)
//any gentleman 40 years or more is Uncle any lady 40 years or more is Aunty,if less than forty
//they become just Mr. or Ms.as the case may be
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender;
            int age;
            Console.WriteLine("Please enter your information:");
            Console.Write("name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("gender(M/F): ");
            gender = Convert.ToString(Console.ReadLine());
            Console.Write("age: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (gender != "M" && gender != "F")
            {
                Console.WriteLine("Please enter correct gender(M/F): ");
                gender = Convert.ToString(Console.ReadLine());
            }
            while(age < 0)
            {
                Console.WriteLine("Please enter correct age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if (age >= 40)
            {
                if (gender == "M")
                {
                    Console.WriteLine("Good Morning Uncle " + name);
                }
                else if (gender == "F")
                {
                    Console.WriteLine("Good Morning Aunty " + name);
                }

            }
            else
            {
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
}