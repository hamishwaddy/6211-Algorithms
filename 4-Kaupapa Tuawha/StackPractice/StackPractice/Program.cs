using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** STACKS **********");

            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            Stack stack = new Stack();

            for (int i = 0; i < userInput; i++)
            {
                Console.Write("Enter a number: ");
                stack.Push(Convert.ToInt32( Console.ReadLine()));
                stack.Push(userInput);
            }

            Console.Write("What number do you want at the top of the stack: ");
            int specificValue = int.Parse(Console.ReadLine());

            while (specificValue != (int)stack.Peek())
            {
                stack.Pop();
            }
            Console.WriteLine("Top of the stack: {0}", stack.Peek());

            Console.ReadLine();
            
        }
    }
}
