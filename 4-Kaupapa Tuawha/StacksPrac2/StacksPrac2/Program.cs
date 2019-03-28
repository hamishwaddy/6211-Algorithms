using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksPrac2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose the number of the task you'd like to complete:");
                Console.WriteLine("\n1 - Task 1\n2 - Task 2\n3 - Task 3\n4 - Exit");
                userChoice = Convert.ToInt32(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            Task1.ProgramT1.Main();
                            break;
                        case 2:
                            Task2.ProgramT2.Main();
                            break;
                        case 3:
                            Task3.ProgramT3.Main();
                            break;
                        case 4:
                            Console.WriteLine("Press any key to exit");
                            break;

                        default:
                        Console.WriteLine("You've entered an invalid number");
                            break;

                    }
            } while (userChoice <5);


            Console.ReadLine();
        }
    }
}
