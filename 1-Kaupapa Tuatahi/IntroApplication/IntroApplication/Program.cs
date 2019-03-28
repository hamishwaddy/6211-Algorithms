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
            string input;

            do
            {
                Messages.AppHeader();

                Console.WriteLine("\n\nChoose from the tasks below: ");
                Console.WriteLine("1 - Task 1");
                Console.WriteLine("2 - Task 2");
                Console.WriteLine("3 - Task 3");
                Console.WriteLine("4 - Exit");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ProgramQ1.Main();
                        Console.Clear();
                        break;
                    case "2":
                        ProgramQ2.Main();
                        Console.Clear();
                        break;
                    case "3":
                        ProgramQ3.Main();
                        Console.Clear();
                        break;
                    default:
                        break;
                }

            } while (input != "4");

        }
    }

    public class Messages
    {
        public static void AppHeader()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("** INTRO APPLICATION **");
            Console.WriteLine("***********************");
        }
    }
}
