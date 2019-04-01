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
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question4: Bank Queue ***\n\n");
            Menu();
            

            MyQueue<ArrayList>.DisplayCurrentQueue();


            Console.ReadLine();

        }

        public static void Menu()
        {
            string[] people = {"Trady Joe", "Dr Windy Pops", "Grandpa Bob", "Billy the kid", "Chris on crutches" };
            Console.WriteLine("Choose three customers to add to the queue:");
            Console.WriteLine("\n1 - Tradesman Joe\n2 - Dr Windy Pops\n3 - Grandpa Bob\n4 - Billy the kid\n5 - Chris on crutches");
            string input = Console.ReadLine();

            int qSize = 3;
            for (int i = 0; i < qSize; i++)
            {
                    if (input == "1")
                    {
                        MyQueue<ArrayList>.Enqueue(people[0]);
                        //WaitTime(1);
                        MyQueue<ArrayList>.DeQueue();
                    }
                    else if (input == "2")
                    {
                        MyQueue<ArrayList>.Enqueue(people[1]);
                    }
                    else if (input == "3")
                    {
                        MyQueue<ArrayList>.Enqueue(people[2]);
                    }
                    else if (input == "4")
                    {
                        MyQueue<ArrayList>.Enqueue(people[3]);
                    }
                    else if (input == "5")
                    {
                        MyQueue<ArrayList>.Enqueue(people[4]);
                    }
            }
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
        public static void AddedToQueue(string userName)
        {
            Console.WriteLine("{0} has been added to the queue.", people[]);
        }
    }



}
