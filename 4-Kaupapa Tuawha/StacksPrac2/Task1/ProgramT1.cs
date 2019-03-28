using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task1
{
    public class ProgramT1
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("****** TASK ONE ******");

            Stack stack = new Stack();
            Console.Write("How many items would you like to put into the stack: ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("add an item to the stack");
                stack.Push(Console.ReadLine());
            }

            Console.Write("What item would you like at the top of the stack: ");
            string item = Console.ReadLine();

            while ((string)stack.Peek() != item)
            {
                stack.Pop();
            }

            Console.Write("Top of the stack: {0}", stack.Peek());


            Console.ReadLine();
        }
    }
}
