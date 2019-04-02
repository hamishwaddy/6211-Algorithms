using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Question3;
using System.Diagnostics;
using System.Threading;

namespace Question4
{
    public static class ProgramQ4v2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question4: Bank Queue ***\n\n");
            Console.WriteLine("Choose 3 different customers to add to the queue.\n");
            Console.WriteLine("\n1 - Tradesman Joe\n2 - Dr Windy Pops\n3 - Grandpa Bob\n4 - Billy the kid\n5 - Chris on crutches\n");

            int qSize = 3;
            int custNum = 1;

            for (int i = 0; i < qSize; i++)
            {
                Console.Write("Add customer {0}: ", custNum);
                string input = Console.ReadLine();
                SelectCustomers(input);
                custNum++;
            }
            Console.WriteLine();
            Messages.DisplayQueue();
            Console.WriteLine("\nPress any key to process the customers.");
            string userInput = Console.ReadLine();

            Console.ReadLine();

        }

     
        public static void SelectCustomers(string input)
        {
            if (input == "1")
            {
                Customer customer = new Customer("Tradesman Joe", 5);
                MyQueue<ArrayList>.Enqueue(customer.Name);                    
            }
            else if (input == "2")
            {
                Customer customer = new Customer("Dr Windy Pops", 2);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "3")
            {
                Customer customer = new Customer("Grandpa Bob", 8);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "4")
            {
                Customer customer = new Customer("Billy the kid", 3);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "5")
            {
                Customer customer = new Customer("Chris on crutches", 6);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }

        public static void ProcessCustomers()
        {

        }

        public static void WaitTime(int seconds)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("[DONE]");

            //Stopwatch stopwatch = Stopwatch.StartNew();
            //Thread.Sleep(1000);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }

    public static class Messages
    {
        public static void DisplayQueue()
        {
            Console.WriteLine("Current customers in the queue: ");

            foreach (string item in ProgramQ3.words)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Customer
    {
        //PROPERTIES
        public string Name { get; set; }
        public int WaitTime { get; set; }

        //CONSTRUCTOR
        public Customer(string name, int waitTime)
        {
            Name = name;
            WaitTime = waitTime;
        }
    }



}
