using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class ProgramT4
    {
        public static void Main()
        {
            Random randGen = new Random();

            Console.WriteLine("This program will display 1000 random doubles between 1 & 10.\n\n");

            double[] dubArr=new double[1000];

            for (int i = 0; i < dubArr.Length; i++)
            {
                dubArr[i] = randGen.NextDouble() *10;
                Console.Write("{0   ,0:N4} ", dubArr[i]);
                Formatting(i);
            }

            Console.WriteLine("Press enter to return to the main menu.");
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
