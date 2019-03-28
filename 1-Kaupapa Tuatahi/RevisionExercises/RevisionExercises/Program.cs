using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Messages.Welcome();
            MainMenu.Menu();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("One");
            PrintHelloName.Print();
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Two");
            SumTwoNums.Add2Nums(74,36);
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Three");
            Divide2Nums.DivideTwoNums(50,3);
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Four");
            Multiply2Nums.Mult2Nums(25,5);
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Five");
            TimesTable.CreateTimesTableList(TimesTable.TakeUserInput());
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Six");
            //CircleCalculator.GetUserRadius();
            //CircleCalculator.CalculatePerimeter(CircleCalculator.GetUserRadius());
            //CircleCalculator.CalculateArea();

            CircleCalculator.DisplayResults(CircleCalculator.GetUserRadius(), CircleCalculator.CalculatePerimeter(CircleCalculator.GetUserRadius()), CircleCalculator.CalculateArea(CircleCalculator.GetUserRadius()));
            Messages.Exit();


            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Seven");
            Swap2Variables.Swap2Nums();
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Eight");
            _1000RandomNums.DeclareArray();
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Messages.ExerciseHeading("Nine");
            RandThreeDigitNums.CreateArray();
            Messages.Exit();

            Console.Clear();
            Messages.Welcome();
            Person.CreatePersons();
            Messages.Exit();
                





        }
    }
}
