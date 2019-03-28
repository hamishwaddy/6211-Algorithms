using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** TASK 3 *****");

            Stack stack = new Stack();
            Console.WriteLine("Enter a sentence...");
            string userInput = (Console.ReadLine());
           

            foreach (char x in userInput)
            {
                stack.Push(x);
            }

            int size = stack.Count;

            for (int i = 0; i < size; i++)
            {
                Console.Write(stack.Pop());
            }

            Console.ReadLine();

        }
    }
}
