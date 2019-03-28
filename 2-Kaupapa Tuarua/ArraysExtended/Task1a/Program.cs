using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    public class ProgramT1a
    {

        public static void Main()
        {

            Console.WriteLine("**********Arrays Extended Exercises**********\n\n");
            Console.WriteLine("TASK 1A\nThis program will create an array of 1000 random doubles between 0-10 with 10 elements per row.\n\n");

            Random Rand = new Random();
            double[] dubArr = new double[1000];
            for (int i = 0; i < dubArr.Length; i++)
            {
                dubArr[i] = Math.Round(Rand.NextDouble(), 4) * 10;
                Console.Write("{0}\t", dubArr[i]);
                Display(i);
            }

            Console.WriteLine("\n\nTASK 1B\nCopy array and execute LINQ query to identify numbers greater than 2.");
            double[] dubArrCopy = new double[dubArr.Length];
            dubArr.CopyTo(dubArrCopy,0);

            //QUERY CREATION
            var greaterThanTwo =
                from number in dubArrCopy
                where number >= 2
                select number;

            //QUERY EXECUTION
            Console.WriteLine("\n\n********** Numbers greater than two **********");
            int y = 0;
            foreach (double i in greaterThanTwo)
            {
                Console.Write("{0}\t", i);
                y++;
                if (y%10==0)
                    Console.WriteLine();

            }


            //TASK 1C
            Console.WriteLine("\n\nTASK 1C\nConvert queried data into new array and display ascending & descending.");
            double[] dubArr3 = greaterThanTwo.ToArray();
            Array.Sort(dubArr3);
            Console.WriteLine("\nSORTED ARRAY");
            int j = 0;
            foreach (double x in dubArr3)
            {
                Console.Write("{0}\t", x);
                j++;
                if (j % 10 == 0)
                    Console.WriteLine();
            }

            Array.Reverse(dubArr3);
            Console.WriteLine("\n\nREVERSE ARRAY");
            int z = 0;
            foreach (double x in dubArr3)
            {
                Console.Write("{0}\t", x);
                z++;
                if(z%10==0)
                    Console.WriteLine();
            }

            Console.ReadLine();

        }

        public static void Display(int i)
        {
            int rowCount = 10;
            if ((i + 1) % rowCount == 0)
                Console.WriteLine();
        }
    }
}
