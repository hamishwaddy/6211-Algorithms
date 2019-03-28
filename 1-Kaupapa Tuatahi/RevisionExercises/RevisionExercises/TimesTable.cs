using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    class TimesTable
    {
        public static int TakeUserInput()
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static void CreateTimesTableList(int input)
        {
            for (int i = 1; i < 11; i++)
            {
                int total = i * input;
                Console.WriteLine("{0} x {1} = {2}", i, input, total);
            }
        }

    }
}