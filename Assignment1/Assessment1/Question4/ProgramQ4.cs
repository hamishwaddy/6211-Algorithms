using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question3;
using System.Collections;

namespace Question4
{
    public static class ProgramQ4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question4: Bank Queue ***\n\n");

            string input = "";
            int qSize = 3;
            for (int i = 0; i < qSize; i++)
            {
                do
                {
                    Console.WriteLine("Choose three customers to add to the queue:");
                    Console.WriteLine("\n1 - Tradesman Joe\n2 - Dr Windy Pops\n3 - Grandpa Bob\n4 - Billy the kid\n5 - Chris on crutches");
                    input = Console.ReadLine(MyQueue<string>.Enqueue());
                } while (true);
            }


            

        }
    }

    public class Customers
    {
        public string MyProperty { get; set; }
    }

}
