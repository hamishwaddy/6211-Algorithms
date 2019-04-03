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
        public static ArrayList customers = ProgramQ3.words;
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
                Customer.SelectCustomers(input);
                custNum++;
            }
            ProgramQ3.words = customers; // copying original ArrayList to preserve original data
            Console.WriteLine();
            Console.WriteLine("\nPress any key to process the customers.");
            string userInput = Console.ReadLine();
            Messages.DisplayQueue();

            //for (int i = 0; i < customers.Count; i++)
            //{
            //    Customer.Process(i.);
            //}

            foreach (Customer item in customers)
            {
                Customer.Process(item.WaitTime);
            }


            Console.ReadLine();

        }
     
    }

    public static class Messages
    {
        public static void DisplayQueue()
        {
            Console.WriteLine("Current customers in the queue: ");

            foreach (string item in ProgramQ4v2.customers)
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

        public static void SelectCustomers(string input)
        {
            if (input == "1")
            {
                Customer customer = new Customer("Tradesman Joe", 5000);
                MyQueue<ArrayList>.Enqueue(customer.Name);                    
            }
            else if (input == "2")
            {
                Customer customer = new Customer("Dr Windy Pops", 2000);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "3")
            {
                Customer customer = new Customer("Grandpa Bob", 8000);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "4")
            {
                Customer customer = new Customer("Billy the kid", 3000);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else if (input == "5")
            {
                Customer customer = new Customer("Chris on crutches", 6000);
                MyQueue<ArrayList>.Enqueue(customer.Name);
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }

        public static void Process(int waitTime)
        {
            //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.0));
            //Console.WriteLine("[DONE]");

            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(waitTime);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
