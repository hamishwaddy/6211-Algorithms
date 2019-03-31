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
        public static ArrayList words = new ArrayList();
        public static ArrayList wordsCopy = words;
        public static ArrayList wordsCopyDequeue = words;


        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question3: Queue Implementation ***\n\n");
            Console.WriteLine("*** Adding items to the queue ***");
            ObtainInfo();
            MyQueue<ArrayList>.DisplayCurrentQueue();
            Console.Write("\n\nPress any key to continue: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*** Question3: Queue Implementation ***\n\n");
            Console.WriteLine("*** Removing items from the queue ***\n");
            MyQueue<ArrayList>.DisplayCurrentQueue();
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
                MyQueue<ArrayList>.Enqueue(input);
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
                ProgramQ3.wordsCopyDequeue.RemoveAt(0);

                MyQueue<ArrayList>.DisplayCurrentDeQueuedQueue();

                Console.Write("\nWould you like to dequeue another item (y/n)? ");
                answer = Console.ReadLine();

            } while (answer == "y");
        }
    }


    public static class MyQueue<ArrayList>
    {
        public static void Enqueue(string input)
        {
            ProgramQ3.words.Add(input);
        }

        public static void DeQueue()
        {
            ProgramQ3.wordsCopyDequeue.RemoveAt(0);
        }

        public static void DisplayCurrentQueue()
        {
            Console.WriteLine("\nCurrent Queue items");
            foreach (string item in ProgramQ3.words)
            {
                Console.WriteLine(item);
            }
        }

        public static void DisplayCurrentDeQueuedQueue()
        {
            Console.WriteLine("Current items in the queue: {0}", ProgramQ3.wordsCopyDequeue.Count);

            foreach (string item in ProgramQ3.wordsCopyDequeue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
