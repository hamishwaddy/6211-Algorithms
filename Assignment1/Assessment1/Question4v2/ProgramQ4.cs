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
    public static class ProgramQ4
    {
        public static MyQueue<Customer> cust = new MyQueue<Customer>();
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question4: Bank Queue ***\n\n");
            Console.WriteLine("Choose 3 different customers to add to the queue.\n");
            Console.WriteLine("\n1 - Tradesman Joe\n2 - Dr Windy Pops\n3 - Grandpa Bob\n4 - Billy the kid\n5 - Chris on crutches\n");
            int qSize = 3;

            for (int i = 0; i < qSize; i++)
            {
                Console.Write("Add customer {0}: ", i+1);
                string input = Console.ReadLine();
                SelectCustomers(input);
            }

            Console.WriteLine("\nPress any key to process the customers.");
            string userInput = Console.ReadLine();

            foreach (Customer x in MyQueue<Customer>.queue)
            {
                x.Process(x);
                //if (x.Name == "Billy the kid")
                //{
                //    MyQueue<Customer>.queue.Remove(x);
                //    MyQueue<Customer>.queue.Add(x);
                //}
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        public static void SelectCustomers(string input)
        {
            if (input == "1")
            {
                cust.Enqueue(new Customer("Tradesman Joe", 5000));
            }
            else if (input == "2")
            {
                cust.Enqueue(new Customer("Dr Windy Pops", 2000));
            }
            else if (input == "3")
            {
                cust.Enqueue(new Customer("Grandpa Bob", 8000));
            }
            else if (input == "4")
            {
                cust.Enqueue(new Customer("Billy the kid", 3000));
            }
            else if (input == "5")
            {
                cust.Enqueue(new Customer("Chris on crutches", 6000));
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
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

        public void Process(Customer x)
        {
            //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.0));
            //Console.WriteLine("[DONE]");
            Console.WriteLine($"Currently processing: {x.Name}");
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(x.WaitTime);
            stopwatch.Stop();
            Console.WriteLine($"Processing time: {stopwatch.ElapsedMilliseconds} milliseconds\n");
        }
    }
}
