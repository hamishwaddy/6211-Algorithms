using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    class Messages
    {

        public static void Welcome()
        {
            Console.WriteLine("******************");
            Console.WriteLine("REVISION EXERCISES");
            Console.WriteLine("******************");
        }

        public static void Exit()
        {
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }

        public static void ExerciseHeading(string message)
        {
            Console.WriteLine("Exercise " + message);
        }

    }
}
