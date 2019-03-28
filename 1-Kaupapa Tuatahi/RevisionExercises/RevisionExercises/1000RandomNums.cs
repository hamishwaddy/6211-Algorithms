using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    public class _1000RandomNums
    {
       
        public static void DeclareArray()
        {
            Random rand = new Random();

            int[] randNums = new int[1000];

            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(1000,10000);
                Console.Write(randNums[i] + " ");
            }
        }

    }
}
