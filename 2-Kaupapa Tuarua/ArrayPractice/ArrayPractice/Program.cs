using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;
using Task4;

namespace ArrayPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.WriteLine("Select from the options below...");
                Console.WriteLine("1 = Task 1 (byte array)");
                Console.WriteLine("2 = Task 2 (1000 random ints array)");
                Console.WriteLine("3 = Task 3 (1000 random 4-digit integer array)");
                Console.WriteLine("4 = Task 4 (1000 random doubles between 1 & 10)");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        ProgramT1.Main();
                        break;
                    case "2":
                        Console.Clear();
                        ProgramT2.Main();
                        break;
                    case "3":
                        Console.Clear();
                        ProgramT3.Main();
                        break;
                    case "4":
                        Console.Clear();
                        ProgramT4.Main();
                        break;

                    default:
                        break;

                }

            } while (userChoice != "4");

        }

        
    }
}
