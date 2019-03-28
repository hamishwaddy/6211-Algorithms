using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    class Swap2Variables
    {
        public static void Swap2Nums()
        {
            int A=10;
            int B=20;
            int temp;

            Console.WriteLine("Before swap:\tA = {0}\tB = {1}", A, B);

            temp = A;
            A = B;
            B = temp;

            Console.WriteLine("After swap:\tA = {0}\tB = {1}", A, B);
        }
    }
}
