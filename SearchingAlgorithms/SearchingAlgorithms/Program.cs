using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Program
    {
        static int[] nums = new int[100000];
        static int[] numsCopy = new int[nums.Length];

        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*********** SEARCHING ALGORITHMS ***************");
            Console.WriteLine("************************************************");

            //int[] nums = new int[100000];
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1000);
                //Console.Write(nums[i] + " ");
                //if ((i+1) % 15 == 0)
                    //Console.WriteLine();
            }

            Console.Write("\n\nTotal count: {0}", nums.Count());

            Console.Write("\n\nChoose a 3-digit number to search for: ");
            if (Searching<int>(nums, int.Parse(Console.ReadLine())))
                Console.WriteLine("\nYour number was found");
            else
                Console.WriteLine("\nYour number was not found");

            int[] numsCopy = new int[nums.Length];
            nums.CopyTo(numsCopy, 0);
            Array.Sort(numsCopy);

            Console.WriteLine("\n\nEnter a number to search for");
            int input = int.Parse(Console.ReadLine());

            // SEARCH FOR THE NUMBER & GIVE RESPONSE
            if (Find(numsCopy, input))
                Console.WriteLine("\nThe number " +input+ " was found");
            else
                Console.WriteLine("\nThe number " +input+ " was not found");
            

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadLine();
        }

        static bool Find(int[] arr, int val)
        {
            
            
            // CREATE NECESSARY VARIABLES
            int upper, mid, lower;
            upper = numsCopy.Length;
            lower = 0;

            // LOOP UNTIL LOWER POINT IS GREATER THAN UPPER, THEN BREAK
            while (lower <= upper)
            {
                // SET THE MID-POINT
                mid = lower + (upper - lower) / 2;
                // IF MID POINT IS THE VALUE WE WANT, RETRUN TRUE
                if (mid == val)
                    return true;
                // IF THE VALUE IS LESS THAN MID-POINT, MOVE UPPER DOWN TO HALFWAY TO SEARCH BOTTOM HALF
                else if (val < arr[mid])
                    upper = mid - 1;
                // IF THE VALUE IS MORE THAN MID-POINT, MOVE LOWER UP TO HALFWAY TO SEARCH TOP HALF
                else
                    lower = mid + 1;
            }
            // IF VALUE ISN'T FOUND, RETURN FALSE
            return false;

        }

        static bool Searching<T>(T[] arr, T val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }
    }
}
