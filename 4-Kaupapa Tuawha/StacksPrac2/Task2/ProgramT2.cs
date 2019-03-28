using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2
{
    public class ProgramT2
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("****** TASK TWO ******");

            Stack stack = new Stack();
            Console.WriteLine("How many numbers would you like to enter: ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                Console.Write("Enter number: ");
                stack.Push(Console.ReadLine());
            }

            Console.WriteLine("\nStack numbers, in reverse order");
            for (int i = 0; i < userInput; i++)
            {
                Console.Write(stack.Pop()+ " ");
            }

            Console.ReadLine();
        }
    }
}
