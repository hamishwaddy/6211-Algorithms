using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    public class RandThreeDigitNums
    {

        public static void Main()
        {
            Random rand = new Random();

            int[] Nums = new int[100];

            for (int i = 0; i < Nums.Length; i++)
            {
                int number = rand.Next(100, 1000);
                while (Nums.Contains(number))
                {
                    number = rand.Next(100, 1000);
                }
                Nums[i] = number;
            }

            for (int i = 1; i <= Nums.Length; i++)
            {
                Console.Write(Nums[i - 1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted array to check for unique numbers");
            Array.Sort(Nums);

            for (int i = 1; i <= Nums.Length; i++)
            {
                Console.Write(Nums[i-1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();

            }
                Console.ReadLine();
        }
    }
}
