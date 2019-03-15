using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dataset = DataCreation();
            Console.WriteLine("Original dataset");
            foreach (int x in dataset)
            {
                Console.Write(x + " ");
            }

            //QUERY CREATION
            var oddNums =
                from number in dataset
                where (number % 2 != 0)
                select number;

            //QUERY EXECUTION
            Console.WriteLine("\n\nOdd numbers in dataset");
            foreach (var x in oddNums)
            {
                Console.Write(x + " ");
            }

            //COPY oddNums TO NEW ARRAY
            Console.WriteLine("\n\nOdd numbers array sorted");
            int[] oddNumsArr = oddNums.ToArray();
            Array.Sort(oddNumsArr);
            foreach (int x in oddNumsArr)
            {
                Console.Write(x + " ");
            }



            Console.ReadLine();
        }

        static int[] DataCreation()
        {
            Random rand = new Random();
            int[] intArr = new int[10];

            for (int i = 0; i < intArr.Length; i++)
            {
                int number = rand.Next(1, 21);
                while(intArr.Contains(number))
                {
                    number = rand.Next(1, 21);
                }
                intArr[i] = number;
            }
            return intArr;
        }
    }

}
