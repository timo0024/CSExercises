using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main()
        {
            //Ex23a

            /*int i, guess;
            int j = 1;
            Random r = new Random();
            i = r.Next(0, 10);
            Console.Write("Please enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            while (i != guess)
            {
                Console.Write("Please enter your guess again: ");
                guess = Convert.ToInt32(Console.ReadLine());
                j++;
            }
            Console.WriteLine("Congratulations! Your attemps is: " + j);*/

            //Ex23b

            int i, guess;
            int j = 1;
            Random r = new Random();
            i = r.Next(0, 10);
            Console.Write("Please enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            while (i != guess)
            {
                Console.Write("Try again: ");
                guess = Convert.ToInt32(Console.ReadLine());
                j++;
            }
            if (j <= 2)
            {
                Console.WriteLine("Congratulations! Your attemps is: " + j);
                Console.WriteLine("You are a Wizard!");
            }
            else if (j <= 5)
            {
                Console.WriteLine("Congratulations! Your attemps is: " + j);
                Console.WriteLine("You are a good guess!");
            }
            else
            {
                Console.WriteLine("Congratulations! Your attemps is: " + j);
                Console.WriteLine("You are lousy!");
            }
        }
    }
}
