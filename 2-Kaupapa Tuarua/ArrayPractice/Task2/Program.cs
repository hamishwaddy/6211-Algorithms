using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ProgramT2
    {
        public static void Main()
        {
            Random randGen = new Random();

            Console.WriteLine("Array of 1000 integers\n\n");

            int[] intArr = new int[1000];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = randGen.Next();
                Console.Write("{0}   ",intArr[i]);
                Formatting(i);
            }

            Console.WriteLine("\n\nPress enter to return to the main menu");
            Console.ReadLine();
        }

        public static void Formatting(int i)
        {
            int rowCount = 10;
            if ((i + 1) % rowCount == 0)
                Console.WriteLine();
        }
    }
}
