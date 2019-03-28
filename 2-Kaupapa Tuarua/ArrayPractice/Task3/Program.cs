using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ProgramT3
    {
        public static void Main()
        {
            Random randGen = new Random();
            Console.WriteLine("This program will display 1000 random 4-digit integers.");

            int[] arr = new int[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randGen.Next(1000, 10000);
                //Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine("Original Data");
            Display(arr);
            Array.Sort(arr);

            Console.Write("\n\nPress enter to sort the array...");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\nSorted Data");
            Display(arr);


            Console.WriteLine("\n\nPress enter to return to the main menu.");
            Console.ReadLine();

        }

        static void Display(int[] arr)
        {
            for(int i = 1; i<=arr.Length;i++)
            {
                Console.Write(arr[i-1] + " ");
                if(i%20 == 0)
                    Console.WriteLine();
            }
        }
        
    }
}
