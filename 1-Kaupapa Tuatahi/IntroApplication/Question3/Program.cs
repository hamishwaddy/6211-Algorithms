using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class ProgramQ3
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("This program takes a number and creates a times-tables list for it.");
            Console.Write("Enter a number: ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The {0} times-table", input);

            for (int i = 1; i < 11; i++)
            {
                int answer = input * i;
                Console.WriteLine("{0} x {1} = {2}",input, i, answer);
            }

            Console.WriteLine("\n\nPress enter to return to the main menu.");
            Console.ReadLine();

        }
    }
}
