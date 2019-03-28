using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandPrac
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("200 true random bytes, 20 per row");

            Random Rand = new Random();

            int[] Arr = new int[200];

            for (int i = 0; i < Arr.Length; i++)
            {
                int number = Rand.Next(100, 500);
                while(Arr.Contains(number))
                {
                    number = Rand.Next(100,500);
                }
                Arr[i] = number;
            }

            Array.Sort(Arr);
            for (int i = 1; i <= Arr.Length; i++)
            {
                Console.Write(Arr[i-1] + " ");
                if (i % 20 == 0)
                    Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}
