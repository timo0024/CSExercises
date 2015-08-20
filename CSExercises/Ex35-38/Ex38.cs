using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            string temp1, n, m;
            char choose;
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            int i, j, temp,input;

            while(true)
            {
                Console.WriteLine("What do you want to do? Enter number:\n(1) Student rank   (2) Show the detail(names alphabetically)");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\tName\t\tMark");
                Console.WriteLine("     --------------------------");
                while (input != 1 && input != 0)
                {
                    Console.Write("Please enter 1/2: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                if (input == 1)
                {
                    for (i = 0; i < mark.Length; i++)
                    {
                        for (j = i + 1; j < mark.Length; j++)
                        {
                            if (mark[i] < mark[j])
                            {
                                temp = mark[i];
                                mark[i] = mark[j]; 
                                mark[j] = temp;
                                temp1 = name[j];
                                name[j] = name[i];
                                name[i] = temp1;
                            }
                        }
                        Console.WriteLine("\t" + name[i] + "\t\t" + mark[i]);
                    }

                }
                else if (input == 2)
                {
                    for (i = 0; i < name.Length; i++)
                    {
                        for (j = i + 1; j < name.Length; j++)
                        {
                            if (name[i].Substring(0, 1).CompareTo(name[j].Substring(0, 1)) == 1)
                            {
                                temp1 = name[j];
                                name[j] = name[i];
                                name[i] = temp1;
                            }
                            else
                            {
                                int p = 0;
                                while (name[i].Substring(p, 1).CompareTo(name[j].Substring(p, 1)) == 0)
                                {
                                    p++;
                                    
                                    if (name[i].Substring(p, 1).CompareTo(name[j].Substring(p, 1)) == 1)
                                    {
                                        temp1 = name[j];
                                        name[j] = name[i];
                                        name[i] = temp1;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("\t" + name[i] + "\t\t" + mark[i]);
                    }
                }
                Console.Write("Cancel?(Y/N)");
                choose = Convert.ToChar(Console.ReadLine());
                while (choose != 'Y' && choose != 'N' && choose != 'y' && choose != 'n')
                {
                    Console.Write("Please enter Y/N: ");
                    choose = Convert.ToChar(Console.ReadLine());
                }
                if (choose == 'Y'||choose=='y')
                    break;
            }


        }
    }
}
