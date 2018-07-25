using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question3;
using Question2;
using Question1;

namespace IntroApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" *************************************************");
                Console.WriteLine(" **                                             **");
                Console.Write(" **");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                  Main Menu                  ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**");
                Console.WriteLine(" **                                             **");
                Console.WriteLine(" *************************************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please select a project to run");

                Console.WriteLine("Press 1 for project 1...");
                Console.WriteLine("Press 2 for project 2...");
                Console.WriteLine("Press 3 for project 3...");
                Console.WriteLine("Press 4 to exit...");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ProgramQ1.Main();
                        Console.Clear();
                        break;
                    case 2:
                        ProgramQ2.Main();
                        Console.Clear();
                        break;
                    case 3:
                        ProgramQ3.Main();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (input != 4);
        }
    }
}
