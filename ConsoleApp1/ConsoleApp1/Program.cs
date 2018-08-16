using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input");
            string choice = Console.ReadLine();
            Console.WriteLine("What loop?");
            string caseSwitch = Console.ReadLine();


            int first = Convert.ToInt32(choice);
            switch (caseSwitch)
            {


                case "for":

                    Console.WriteLine("input      x10     x100     x1000");
                    for (int ti = 0; ti < 11; ti++)
                    {
                        if (first < 10)
                        {
                            Console.WriteLine("    " + first + "       " + first * 10 + "      " + first * 100 + "      " + first * 1000);
                        }
                        else
                        {
                            Console.WriteLine("    " + first + "      " + first * 10 + "     " + first * 100 + "     " + first * 1000);
                        }

                        first++;

                    }
                    Console.ReadKey();
                    break;
                case "while":
                    int zi = 0;
                    Console.WriteLine("input      x10     x100     x1000");
                    {

                        if (first < 10)
                        {
                            Console.WriteLine("    " + first + "       " + first * 10 + "      " + first * 100 + "      " + first * 1000);
                        }
                        else
                        {
                            Console.WriteLine("    " + first + "      " + first * 10 + "     " + first * 100 + "     " + first * 1000);
                        }

                        first++;
                        zi++;
                    } while (zi < 11) ;
                    Console.ReadKey();
                    break;
                case "do":
                    int qi = 0;
                    Console.WriteLine("input      x10     x100     x1000");
                    do
                    {
                        
                        if (first < 10)
                        {
                            Console.WriteLine("    " + first + "       " + first * 10 + "      " + first * 100 + "      " + first * 1000);
                        }
                        else
                        {
                            Console.WriteLine("    " + first + "      " + first * 10 + "     " + first * 100 + "     " + first * 1000);
                        }

                        first++;
                        qi++;
                    } while (qi < 11);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("try for, while, or do.");
                    Console.ReadKey();
                    break;
            }






            } 
    }
}
