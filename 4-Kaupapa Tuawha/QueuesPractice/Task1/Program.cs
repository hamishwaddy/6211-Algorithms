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
        static void Main(string[] args)
        {
            Console.WriteLine("***** Task 1 *****\n\n");
            Console.WriteLine("Use a loop to populate a queue with names, then display those names back to the user.\n\n");

            Queue q1 = new Queue();

            string check= "y";
            do
            {
                Console.Clear();
                Console.Write("Enter a name: ");
                q1.Enqueue(Console.ReadLine());
                Console.Write("\nDo you want to enter another name y/n: ");
                check = Console.ReadLine().ToLower();
            } while (check=="y");

            Queue q2 = q1;

            Console.Clear();
            while (q2.Count>0)
            {
                Console.WriteLine("Dequeued item: {0}", q2.Dequeue());
            }

            Console.ReadLine();

        }
    }
}
