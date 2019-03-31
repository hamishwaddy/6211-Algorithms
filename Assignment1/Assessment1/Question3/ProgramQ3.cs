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
            Console.WriteLine("*** Adding items to the queue ***\n\n");


            //string answer = "";
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("*** Question3: Queue Implementation ***\n\n");
            //    Console.WriteLine("Choose from the options below: ");
            ////    Console.WriteLine("1 - Enqueue\n2 - Dequeue\n3 - Exit");
            ////    answer = Console.ReadLine();
            ////    if (answer == "1")
            ////        MyQueue<ArrayList>.Enqueue();
            ////    else if (answer == "2")
            ////        MyQueue<ArrayList>.Dequeue();
            ////    else if (answer != "1" || answer != "2")
            ////        Console.WriteLine("Invalid entry, please try again.");
            ////} while (answer != "1" || answer != "2");  //NOT WORKING PROPERLY - TO FIX

            Console.ReadLine();
        }
    }

    public static class MyQueue<ArrayList> //SHOULD THIS BE string OR SOMETHING ELSE???
    {
        public static void Enqueue()
        {
            //Console.Clear();
            //Console.WriteLine("*** Adding items to the queue ***\n\n");

            string answer = "y";
            do
            {
                Console.WriteLine("Add an item to the queue.");
                string input = Console.ReadLine();
                ProgramQ3.words.Add(input);
                Console.Write("Add another word to the queue (y/n)?");
                answer = Console.ReadLine();
            } while (answer != "n"); //THIS LOOP NOT WORKING QUITE RIGHT - NEEDS AN IF STATEMENT???

            Console.Clear();
            Console.WriteLine("*** Adding items to the queue ***\n\n");
            Console.WriteLine("Queue items");
            foreach (string item in ProgramQ3.words)
            {
                Console.WriteLine(item);
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadLine();
        }

        public static void Dequeue()
        {
            Console.Clear();
            Console.WriteLine("*** Removing items from the queue ***\n\n");

            Console.WriteLine("Current items in the queue: {0}",ProgramQ3.wordsCopyDequeue.Count);

            foreach (string item in ProgramQ3.wordsCopyDequeue)
            {
                Console.WriteLine(item);
            }

            string answer = "";
            do
            {
                Console.Write("\nPress the 'd' key to dequeue the next item.");
                string input = Console.ReadLine();
                ProgramQ3.wordsCopyDequeue.RemoveAt(0);

                Console.WriteLine("\nCurrent items in the queue: {0}", ProgramQ3.wordsCopyDequeue.Count);
                foreach (string item in ProgramQ3.wordsCopyDequeue)
                {
                    Console.WriteLine(item);
                }
                Console.Write("\nWould you like to dequeue another item (y/n)? ");
                answer = Console.ReadLine();

            } while (answer == "y");

            Console.Write("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
