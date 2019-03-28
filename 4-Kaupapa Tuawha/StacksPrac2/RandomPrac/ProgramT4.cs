using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPrac
{
    public class ProgramT4
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("***** Random generator practice *****");

            Random rand = new Random();
            int[] arr = new int[21];

            for (int i = 0; i < arr.Length; i++)
            {
                int number = rand.Next(50, 100);
                while (arr.Contains(number))
                {
                    number = rand.Next(50, 100);
                }
                arr[i] = number;
                Console.Write(arr[i] + " ");
            }




            //Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
