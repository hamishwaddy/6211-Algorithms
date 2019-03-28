using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandPrac2;

namespace RandPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("300 random ints, 15 per row");

            Random Rand = new Random();

            int[] intArr = new int[300];
            //Rand.NextBytes(byteArr);

            for (int i = 0; i < intArr.Length; i++)
            {
                int number = Rand.Next(1,256);
                while(intArr.Contains(number))
                {
                    number = Rand.Next(1,256);
                }
                intArr[i]=number;
            }

            Array.Sort(intArr);

            for (int i = 1; i <= intArr.Length; i++)
            {
                Console.Write(intArr[i - 1] + " ");
                if (i % 15 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
