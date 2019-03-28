using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3
{
    public class ProgramT3
    {
        public static void Main()
        {
            Console.Clear();
            Stack stack = new Stack();
            Console.WriteLine("Enter a word, phrase or sentence");
            string userInput = Console.ReadLine();

            foreach (char item in userInput)
            {
                stack.Push(item);
            }
            int size = stack.Count;

            Console.WriteLine("Here's your input in reverse order: ");
            for (int i = 0; i < size; i++)
            {
            Console.Write(stack.Pop() + " ");
            }

            Console.ReadLine();
        }
    }
}
