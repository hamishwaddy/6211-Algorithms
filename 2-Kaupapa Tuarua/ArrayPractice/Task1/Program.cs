using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ProgramT1
    {
        public static void Main()
        {
            Random randGen = new Random();
            byte[] byteArray = new byte[1000];

            randGen.NextBytes(byteArray);
            Console.WriteLine("**** 1000 Random byte values ****");
            foreach (byte x in byteArray)
            {
                Console.Write("{0} ", x);
                //Formatting(x);
            }

            Console.WriteLine("\n\nPress any key to sort the array.");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Array sorted into descending order");
            Array.Sort(byteArray);
            Array.Reverse(byteArray);
            foreach (byte x in byteArray)
            {
                Console.Write("{0} ", x);
                //Formatting(x);
            }

            Console.WriteLine("\n\nPress enter to key to return to main menu");
            Console.ReadLine();
        }

        

        static void Formatting(int i)
        {
            int rowcount = 10;

            if ((i + 1) % rowcount == 0)
                Console.WriteLine();
        }
    }
}
