using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace May17InsertionSort
{
    class Program
    {
        static Random random = new Random();
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            int[] data = new int[100000];
            Populate(data);

            int[] dataClone = new int[data.Length];
            Array.Copy(data, dataClone, data.Length);

            Console.WriteLine("\nOriginal data set");
            //Display(data);
            //Console.WriteLine("\nClone");
            //Display(dataClone);

            Console.WriteLine("\nSelection Sort");
            stopwatch.Start();
            SelectionSort(dataClone);
            stopwatch.Stop();
            Console.WriteLine("Time to sort: {0} ms", stopwatch.ElapsedMilliseconds);
            //Display(dataClone);

            Console.WriteLine("\nBubble Sort");
            int[] dataClone2 = new int[data.Length];
            Array.Copy(data, dataClone2, data.Length);
            stopwatch.Start();
            BubbleSort(dataClone2);
            stopwatch.Stop();
            Console.WriteLine("Time to sort: {0} ms", stopwatch.ElapsedMilliseconds);
            //Display(dataClone2);

            Console.WriteLine("\nImproved Bubble Sort");
            int[] dataClone3 = new int[data.Length];
            Array.Copy(data, dataClone3, data.Length);
            stopwatch.Start();
            ImprovedBubbleSort(dataClone3);
            stopwatch.Stop();
            Console.WriteLine("Time to sort: {0} ms", stopwatch.ElapsedMilliseconds);
            //Display(dataClone3);


            Console.ReadLine();

        }
        public static int[] Populate(int[] arr)
        {
            //int[] data = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
            }
            return arr;
        }
        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if ((i+1)%10==0)
                {
                    Console.WriteLine();
                }
                 
            }
        }
        public static int[] SelectionSort(int[] arr)
        {
            for (int outter = 0; outter < arr.Length; outter ++)
            {
                int min = outter; // Create starting point for lowest number
                for (int inner=outter+1; inner< arr.Length; inner++) // Linear search
                {
                    if (arr[inner] < arr[min])
                        min = inner; // Store lowest number in 'min' variable
                }
                int temp = arr[outter]; // Once the lowest value is found perform ...
                arr[outter] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }
        public static int[] BubbleSort(int[] arr)
        {
            // outer loop
            for (int i = 0; i < arr.Length-1; i++)
            {
                // internal loop
                for (int j = 0; j < arr.Length-1; j++)
                {
                    // if current element is larger, swap
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            return arr;
        }
        public static int[] ImprovedBubbleSort(int[] arr)
        {
            bool swap = true;
            // external loop
            for (int i = 0; i < arr.Length-1; i++)
            {
                swap = false;
                // internal loop
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    // if current element is larger than next, swap
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        // check if swaps have been made
                        swap = true;
                    }
                }
                // if no swaps are made, break
                if (!swap)
                    break;
            }
            return arr;
        }
    }
}
