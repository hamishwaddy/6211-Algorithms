using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Question3;

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
            Console.WriteLine("Choose three customers to add to the queue:");
            Console.WriteLine("\n1 - Tradesman Joe\n2 - Dr Windy Pops\n3 - Grandpa Bob\n4 - Billy the kid\n5 - Chris on crutches");
            string input = Console.ReadLine();

            int qSize = 3;
            for (int i = 0; i < qSize; i++)
            {
                switch (input)
                {
                    case "1":
                        MyQueue<ArrayList>.Enqueue(input);
                        break;
                    case "2":
                        MyQueue<ArrayList>.Enqueue(input);
                        break;
                    case "3":
                        MyQueue<ArrayList>.Enqueue(input);
                        break;
                    case "4":
                        MyQueue<ArrayList>.Enqueue(input);
                        break;
                    case "5":
                        MyQueue<ArrayList>.Enqueue(input);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public static class Messages
    {
        public static void AddedToQueue(string userName)
        {
            Console.WriteLine("{0} has been added to the queue.", userName);
        }
    }



}
