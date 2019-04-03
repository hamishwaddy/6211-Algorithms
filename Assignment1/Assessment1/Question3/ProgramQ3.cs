using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question3
{
    public static class ProgramQ3
    {
        public static MyQueue<string> words = new MyQueue<string>();



        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question3: Queue Implementation ***\n\n");
            Console.WriteLine("*** Adding items to the queue ***");
            ObtainInfo();
            words.DisplayCurrentQueue();
            Console.Write("\n\nPress any key to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*** Question3: Queue Implementation ***\n\n");
            Console.WriteLine("*** Removing items from the queue ***\n");
            words.DisplayCurrentQueue();
            DequeueMessage();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static string ObtainInfo()
        {
            string input = "";
            string answer = "y";
            do
            {
                Console.WriteLine("Add an item to the queue.");
                input = Console.ReadLine();
                words.Enqueue(input);
                Console.Write("Add another word to the queue (y/n)?");
                answer = Console.ReadLine();
            } while (answer != "n");
            return input;
        }

        public static void DequeueMessage()
        {
            string answer = "";
            do
            {
                Console.Write("\nPress the 'd' key to dequeue the item at the front of the queue: ");
                string input = Console.ReadLine();
                Console.WriteLine($"Item Dequeued: {words.DeQueue()}"); 

                words.DisplayCurrentDeQueuedQueue();

                Console.Write("\nWould you like to dequeue another item (y/n)? ");
                answer = Console.ReadLine();

            } while (answer == "y");
        }
    }


    public class MyQueue<T>
    {
        public static ArrayList queue = new ArrayList();
        public void Enqueue(T input)
        {
            queue.Add(input);
        }

        public string DeQueue()
        {
            object x = queue[0];
            queue.RemoveAt(0);
            return x.ToString();
        }

        public void DisplayCurrentQueue()
        {
            Console.WriteLine("\nCurrent Queue items");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayCurrentDeQueuedQueue()
        {
            Console.WriteLine("Current items in the queue: {0}",queue.Count);

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
