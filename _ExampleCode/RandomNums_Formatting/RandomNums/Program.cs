using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] intArr = new int[49];
            for (int i = 0; i < intArr.Length; i++)
            {
                int number = rand.Next(1000, 10000);
                while (intArr.Contains(number))
                {
                    number = rand.Next(1000, 10000);
                }
                intArr[i] = number;
            }

            Console.WriteLine("Random Array formatted with foreach loop");
            int x = 0;
            foreach (int item in intArr)
            {

                Console.Write(item + " ");
                x++;
                if(x%7==0)
                    Console.WriteLine();
            }

            Console.WriteLine("\n\nRandom Array sorted and formatted with for loop");

            int[] intArrSorted = new int[intArr.Length];
            Array.Copy(intArr, intArrSorted, intArr.Length);
            Array.Sort(intArrSorted);
            for (int i = 0; i < intArrSorted.Length; i++)
            {
                Console.Write(intArrSorted[i] + " ");
                if((i+1)%7==0)
                    Console.WriteLine();
            }



            Console.ReadKey();

        }
    }
}
