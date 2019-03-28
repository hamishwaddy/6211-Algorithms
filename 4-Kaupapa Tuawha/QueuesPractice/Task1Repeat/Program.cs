using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task1Repeat
{
    public class ProgramT1
    {
        static void Main(string[] args)
        {
            //declare queue
            //add names to q
            //duplicate q
            //display names
            //exit program
            //search if a name is contained
            //copy q1 to array
            //sort array alphabetically
            //display to user


            Queue q1 = new Queue();
            FirstMessage();
            q1 = AddNames(q1);
            Queue q2 = q1;
            DisplayNames(q2);
            Queue q3 = q1;

            if (SearchIfNameExists(q3))
            {
                Console.WriteLine("..... Item found .....");
            }
            else
            {
                Console.WriteLine("..... Item not found .....");
            }
            EndTask();

        }

        static Queue AddNames(Queue q)
        {
            string again = "y";
            do
            {
                Console.Clear();
                Console.Write("Enter a name: ");
                q.Enqueue(Console.ReadLine());
                Console.WriteLine("Do you want to add another name (y/n? ");
                again = Console.ReadLine();
            } while (again == "y");
            return q;
        }

        static void DisplayNames(Queue q2)
        {
            while (q2.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Dequeued item: {0}", q2.Dequeue());
            }
        }

        static void EndTask()
        {
            Console.WriteLine("This is the end.\nPress any key to exit.");
        }

        static void FirstMessage()
        {
            Console.WriteLine("***** QUEUES PRACTICE ******");
            Console.WriteLine("********* Task 1 ***********");
            Console.WriteLine("\n\nUse a loop to populate a queue with names, then display these back to the user.");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
        }

        static bool SearchIfNameExists(Queue q3)
        {
            Console.Write("What name would you like to search for: ");
            string input = Console.ReadLine();
            bool check = q3.Contains(input);
            Console.WriteLine(q3.Count);
            return check;
        }
        
        
    }
}
