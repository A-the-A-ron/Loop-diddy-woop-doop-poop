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
            string caseRedo = "play";
            while (caseRedo != "no")
            {

                string case20 = "loop";
                do
                {
                    Console.WriteLine("Task 1, 2 or 3.");
                    case20 = Console.ReadLine();
                    switch (case20)
                    {
                        case "1":
                            string safety = "";
                            int first;
                            do
                            {
                                Console.WriteLine("Insert input");
                                
                                if (!Int32.TryParse(Console.ReadLine(), out first))
                                {
                                    Console.WriteLine("retry input");
                                    safety = "yes";
                                }
                                else
                                {
                                    safety = "no";
                                }
                            } while (safety == "yes");
                            string caseSwitch = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseSwitch = Console.ReadLine();


                                ;
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
                                        while (zi < 11)
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
                                        }
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

                                        break;
                                }


                            } while (caseSwitch != "for" && caseSwitch != "while" && caseSwitch != "do");
                            break;
                        case "2":
                            string safer = "";
                            int second;
                            do
                            {
                                Console.WriteLine("Insert input");

                                if (!Int32.TryParse(Console.ReadLine(), out second))
                                {
                                    Console.WriteLine("retry input");
                                    safer = "yes";
                                }
                                else { safer = "no"; }
                            } while (safer == "yes");
                            string caseNew = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseNew = Console.ReadLine();


                                
                                switch (caseNew)
                                {
                                    case "for":
                                        Console.WriteLine(" input\t equation result");

                                        for (int ti = 0; ti < 11; ti++)
                                        {
                                            Console.WriteLine($" {second}\t{second} x 7 ={second * 7}");
                                            second++;


                                        }
                                        Console.ReadKey();
                                        break;
                                    case "while":
                                        int zi = 0;
                                        Console.WriteLine(" input\t equation result");
                                        while (zi < 11)
                                        {
                                            Console.WriteLine($" {second}\t{second} x 7 ={second * 7}");
                                            second++;
                                            zi++;


                                        }
                                        Console.ReadKey();
                                        break;
                                    case "do":
                                        int qi = 0;
                                        Console.WriteLine(" input\t equation\t result");
                                        do
                                        {
                                            Console.WriteLine($" {second}\t{second} x 7 ={second * 7}");
                                            second++;
                                            qi++;


                                        } while (qi < 11);
                                        Console.ReadKey();
                                        break;



                                    default:
                                        Console.WriteLine("try: for, while or do. ");
                                        break;
                                }
                            } while (caseNew != "do" && caseNew != "for" && caseNew != "while");

                            break;
                        case "3":
                            string safest = "";
                            int third;
                            do
                            {
                                Console.WriteLine("Insert input");

                                if (!Int32.TryParse(Console.ReadLine(), out third))
                                {
                                    Console.WriteLine("retry input");
                                    safest = "yes";
                                }
                                else { safest = "no"; }
                            } while (safest == "yes");
                            string caseFinal = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseFinal = Console.ReadLine();

                                
                                switch (caseFinal)
                                {
                                    case "for":
                                        Console.WriteLine("input\t ^2\t ^3");
                                        for (int ti = 0; ti < 11; ti++)
                                        {
                                            Console.WriteLine($"{third}\t {third * third}\t {third * third * third}");
                                            third++;

                                        }
                                        Console.ReadKey();
                                        break;
                                    case "while":
                                        int zi = 0;
                                        Console.WriteLine("input\t ^2\t ^3");
                                        while (zi < 11)
                                        {
                                            Console.WriteLine($"{third}\t {third * third}\t {third * third * third}");
                                            third++;
                                            zi++;
                                        }
                                        Console.ReadKey();
                                        break;
                                    case "do":
                                        int qi = 0;
                                        Console.WriteLine("input\t ^2\t ^3");
                                        do
                                        {
                                            Console.WriteLine($"{third}\t {third * third}\t {third * third * third}");
                                            third++;
                                            qi++;
                                        } while (qi < 11);
                                        Console.ReadKey();
                                        break;



                                    default:
                                        Console.WriteLine("try: for, while or do.");
                                        break;
                                }
                            } while (caseFinal != "for" && caseFinal != "while" && caseFinal != "do");
                            break;

                        default:
                            Console.WriteLine("Please enter 1, 2 or 3.");
                            break;
                    }
                } while (case20 != "1" && case20 != "2" && case20 != "3");
                Console.WriteLine("Would you like to see another exercie? (yes/no)");
                caseRedo = Console.ReadLine();
                switch (caseRedo)
                {
                    case "no":
                        Console.Clear();
                        Console.WriteLine("goodbye.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        break;

                }

            }
        }

        

    }
}
