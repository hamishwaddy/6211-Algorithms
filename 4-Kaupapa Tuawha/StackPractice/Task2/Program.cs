using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Taks 2 *****");

            Console.Write("How many numbers would you like to enter: ");
            int userInput = int.Parse(Console.ReadLine());

            Stack stack = new Stack();

            for (int i = 0; i < userInput; i++)
            {
                Console.Write("What number do you want to add: ");
                stack.Push(Console.ReadLine());
            }


            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(stack.Pop());
            }

                Console.ReadLine();
        }
    }
}
