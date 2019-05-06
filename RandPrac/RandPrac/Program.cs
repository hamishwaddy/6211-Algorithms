using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            string[] namesArr = { "John", "Jack", "Jase", "Dave", "Mike", "Sue", "Lara", "Sam", "Orrie", "Pixie", "Kirsten", "James", "Dan", "Josh", "Hamish", "Jared" };

            Console.WriteLine("Original NAMES array");

            for (int i = 1; i <= namesArr.Length; i++)
            {
                Console.Write(namesArr[i-1] + " ");
                if(i%4==0)
                    Console.WriteLine();
            }

            string[] namesCopy = new string[namesArr.Length];
            namesArr.CopyTo(namesCopy, 0);
            Array.Sort(namesCopy);

            Console.WriteLine("\n\nCopied, sorted array");

            foreach (string i in namesCopy)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nReversed array");
            Array.Reverse(namesCopy);
            foreach (string i in namesCopy)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("ARRAY OF RANDOM INTS");
            int[] intArr = new int[27];
            for (int i = 0; i < intArr.Length; i++)
            {
                int number = rand.Next(1000, 10000);
                while (intArr.Contains(number))
                {
                    number = rand.Next(1000, 10000);
                }
                intArr[i] = number;
            }

            Console.WriteLine("\n\nRandom Ints");
            for (int i = 1; i <= intArr.Length; i++)
            {
                Console.Write(intArr[i-1] + " ");
                if (i%9==0)
                    Console.WriteLine();
            }

           
            Console.ReadLine();

        }
    }
}
