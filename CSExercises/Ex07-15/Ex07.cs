using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// The ABC Company pays its employees salary plus benefits. The benefits are calculated as a percentage of the salary.
// The company pays every employee 10% housing allowance and 3% transprt allowance.
//Write a program that takes the salary as input and prints the total income(salary + housing allowance + transport allowance)as output.
//Format the output in currency format.
namespace CSExercises
{
    public class Ex07
    {
        public static void Main()
        {
            double i, j, k, sum;
            string ci, cj, ck, csum;
            Console.WriteLine("Welcome to calculate total income! Please input the salary:");
            Console.Write("salary(S$): ");
            i = Convert.ToDouble(Console.ReadLine());
            ci = i.ToString("c");
            j = Convert.ToDouble(i * 0.1);
            cj = j.ToString("c");
            k = Convert.ToDouble(i * 0.03);
            ck = k.ToString("c");
            sum = i + j + k;
            csum = sum.ToString("c");
            Console.WriteLine("************details***********");
            Console.WriteLine("salary(S$): " + ci);
            Console.WriteLine("housing allowance(S$): " + cj);
            Console.WriteLine("trasport allowance(S$): " + ck);
            Console.WriteLine("the total income(S$): " + csum);
        }
    }
}
