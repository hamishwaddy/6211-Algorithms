using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class ProgramQ2
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("This program takes 2 numbers and divides them.");

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double total = num1 / num2;
            Console.WriteLine("\n{0} / {1} = {2}",num1,num2,total);

            Console.WriteLine("\n\nPress the enter key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
