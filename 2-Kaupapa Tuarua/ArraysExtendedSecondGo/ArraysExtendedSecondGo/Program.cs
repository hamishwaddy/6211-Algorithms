using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExtendedSecondGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("----- ARRAYS EXTENDED -----");
            Console.WriteLine("---------------------------");


            Random rand = new Random();
            double[] data = new double[1000];
            for (int i = 0; i < data.Length; i++)
            {
                double number = rand.NextDouble() * 10;
                while (data.Contains(number))
                {
                    number = rand.NextDouble() * 10;
                }
                data[i] = number;
            }
            Console.WriteLine("\n\nTask 1A - Create an array of 1000 random doubles that range from 0 - 10 and display the entire data set to the user with only 10 elements per row.");
            Console.WriteLine("\narray via foreach loop");
            int x = 0;
            foreach (double item in data)
            {
                Console.Write(Math.Round(item,4) + "\t");
                x++;
                if(x%10==0)
                    Console.WriteLine();
            }


            Console.WriteLine("\narray via for loop");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(Math.Round(data[i],5) + "\t");
                if((i+1)%10==0)
                    Console.WriteLine();
            }


            Console.WriteLine("\n\nTask 1B - Extend the previous application so that creates another array and copies the contents of the original array to the new one. Now add the functionality so that it uses a LINQ query to find all of the numbers greater than 2 in the copied data set and display them to the user.");
            double[] dataCopy = new double[data.Length];
            Array.Copy(data, dataCopy, data.Length);

            //QUERY CREATION
            var greaterThanTwo = from numbers in data
                                 where numbers > 2
                                 select numbers;

            //QUERY EXECUTION
            Console.WriteLine("\n\n--- NUMBERS GREATER THAN TWO ---\n");
            int y = 0;
            foreach (double item in greaterThanTwo)
            {
                Console.Write("{0}\t",Math.Round(item,3));
                y++;
                if(y%10==0)
                    Console.WriteLine();
            }

            Console.WriteLine("\n\nTask 1C - Convert the resulting data set into an array and display the array to the user in ascend and descending order showing only 10 elements per row.");
            double[] dataFromQuery = greaterThanTwo.ToArray();
            Array.Sort(dataFromQuery);
            Console.WriteLine("\nAscending Array");
            int a = 0;
            foreach (double item in dataFromQuery)
            {
                Console.Write(Math.Round(item, 3) + "\t");
                a++;
                if(a%10==0)
                    Console.WriteLine();
            }

            Array.Reverse(dataFromQuery);
            Console.WriteLine("\n\nDescending Array");
            int b = 0;
            foreach (double item in dataFromQuery)
            {
                Console.Write(Math.Round(item, 3) + "\t");
                b++;
                if (b%10==0)
                    Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
