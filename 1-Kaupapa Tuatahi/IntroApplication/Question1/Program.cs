using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class ProgramQ1
    {
        public static void Main()
        {
            Console.Clear();
            
            //HOW DO I ACCESS IntroApplication.Messages.AppHeader from here?

            Console.WriteLine("This program takes 2 numbers and multiplies them together.");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int total = num1 * num2;
            Console.WriteLine("{0} x {1} = {2}", num1, num2, total);

            Console.WriteLine("\n\nPress enter to return to the main menu.");
            Console.ReadLine();
            
        }
    }
}
