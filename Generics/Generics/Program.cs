using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Question 1 ***\n\n");
            Console.Write("Enter a number: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("\nNow enter a word: \n\n");
            string input2 = Console.ReadLine();
            ComparisonClass<int, string> check = new ComparisonClass<int, string>();
            if (check.Comparison(input1, input2))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are different");

            Console.WriteLine("Press any key to enter");
            Console.ReadLine();
        }
    }

    class ComparisonClass <I,S>
    {
        public bool Comparison(I input1, S input2)
        {
            if (input1.ToString().Equals(input2.ToString()))
                return true;
            else
                return false;
        }
    }
}
