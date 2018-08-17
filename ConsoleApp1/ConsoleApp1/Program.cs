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

                            Console.WriteLine("Insert input");
                            string choice = Console.ReadLine();
                            string caseSwitch = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseSwitch = Console.ReadLine();


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
                            Console.WriteLine("Insert input");
                            string Newchoice = Console.ReadLine();
                            string caseNew = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseNew = Console.ReadLine();


                                int second = Convert.ToInt32(Newchoice);
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
                            Console.WriteLine("Insert input");
                            string choiceThird = Console.ReadLine();
                            string caseFinal = "loop";
                            do
                            {
                                Console.WriteLine("What loop?");
                                caseFinal = Console.ReadLine();

                                int third = Convert.ToInt32(choiceThird);
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
