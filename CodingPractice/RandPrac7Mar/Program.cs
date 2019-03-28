using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandPrac7Mar
{
    public class Program7Mar
    {
        static void Main()
        {
            //array of 15 random ints between 15&100
            //displayed in random order, 
            //copied to new arrays to display sorted ascending, descending
            //display with 5 ints per column

            Random rand = new Random();
            int[] intArr = new int[15];

            for (int i = 0; i < intArr.Length; i++)
            {
                int number = rand.Next(15,101);
                if(intArr.Contains(number))
                {
                    intArr[i] = rand.Next(15,100);
                }
                intArr[i] = number;
            }

            Console.WriteLine("Array of 15 random numbers");
            for (int i = 1; i <= intArr.Length; i++)
            {
                Console.Write(intArr[i - 1] + " ");
                if ((i) % 5 == 0)
                    Console.WriteLine();
            }


            Console.WriteLine("\n\nSame array as above, sorted ascending");
            int[] intArrAscending = new int[intArr.Length];
            Array.Copy(intArr, intArrAscending, intArr.Length);

            Array.Sort(intArrAscending);
            foreach (int i in intArrAscending)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nSorted descending");
            int[] intArrDescending = new int[intArrAscending.Length];
            Array.Copy(intArrAscending, intArrDescending, intArrAscending.Length);
            Array.Reverse(intArrDescending);
            foreach (int i in intArrDescending)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();
        }
    }
}
