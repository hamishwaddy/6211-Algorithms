using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("***************** BUBBLE SORTING METHODS *****************");
            Console.WriteLine("**********************************************************");

            int[] nums = new int[10000];

            nums = Populate(nums);


            // CLONE ORIGINAL ARRAY
            int[] numsClone = new int[nums.Length];
            Array.Copy(nums, numsClone, nums.Length);

            Console.WriteLine("\n\n************ STANDARD BUBBLE SORT ************\n");
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            StandardBubbleSort(numsClone);
            stopwatch1.Stop();
            Display(numsClone);
            Console.WriteLine("\nTime to perform standard bubble sort was {0} milliseconds", stopwatch1.ElapsedMilliseconds);


            Console.WriteLine("\n\n************ IMPROVED BUBBLE SORT ************\n");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            ImprovedBubbleSort(numsClone);
            stopwatch2.Stop();
            Display(numsClone);
            Console.WriteLine("\nTime to perform standard bubble sort was {0} milliseconds", stopwatch2.ElapsedMilliseconds);







            Console.ReadLine();

        }

        static int[] Populate(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100, 1000);
            }
            return arr;
        }

        static int[] StandardBubbleSort(int[] arr)
        {
            // EXTERNAL LOOP TO CHECK ALL OF ARRAY
            for (int i = 0; i < arr.Length-1; i++)
            {
                // INTERNAL LOOP TO GO THRU ELEMENTS & CHECK EACH ONE
                for (int j = 0; j < arr.Length-1; j++)
                {
                    // IF CURRENT ELEMENT IS LARGER THAN NEXT ELEMENT, SWAP THEM
                    if (arr[j] > arr [j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static int[] ImprovedBubbleSort(int[] arr)
        {
            bool swap = true;
            // EXTERNAL LOOP TO CHECK ALL OF ARRAY
            for (int i = 0; i < arr.Length-1; i++)
            {
                swap = false;
                // INTERNAL LOOP GOES THRU EACH ELEMENT, CHECKS EACH ONE & SUBTRACTS 'i' 
                // AS THE LARGEST ELEMENT IN THE ARRAY IS AT THE END NOW
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    // IF THE CURRENT ELEMENT IS LARGER THAN THE NEXT ELEMENT, SWAP THEM
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        // CHECK IF ANY SWAPS HAVE BEEN MADE FOR DATA THAT'S IN ORDER

                        swap = true;
                    }
                }
                // IF NO SWAPS ARE MADE, BREAK
                if (!swap)
                {
                    break;
                }
            }
            // RETURN THE SORTED DATA
            return arr;
        }

        static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
                if ((i + 1) % 40 == 0)
                    Console.WriteLine();
            }
        }



    }
}
