using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    class MainMenu
    {

        public static void Menu()
        {
            int input = 0;

            do
            {
                Console.Clear();
                Messages.Welcome();
                Console.WriteLine("\n\nChoose from the options below: ");
                Console.WriteLine("1 - Task 1");
                Console.WriteLine("2 - Task 2");
                Console.WriteLine("3 - Task 3");
                Console.WriteLine("4 - Task 4");
                Console.WriteLine("5 - Task 5");
                Console.WriteLine("6 - Task 6");
                Console.WriteLine("7 - Task 7");
                Console.WriteLine("8 - Task 8");
                Console.WriteLine("9 - Task 9");
                Console.WriteLine("10 - Task 10");
                Console.WriteLine("11 - EXIT");

                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine(PrintHelloName.Print());
                        Console.ReadLine();
                        break;
                    case 2:
                        SumTwoNums.Add2Nums(3, 5);
                        break;
                    case 3:
                        Divide2Nums.DivideTwoNums(50, 3);
                        break;
                    case 4:
                        Multiply2Nums.Mult2Nums(5, 25);
                        break;
                    case 5:
                        TimesTable.CreateTimesTableList(6);
                        break;
                    case 6:
                        double rad = CircleCalculator.GetUserRadius();
                        double area = CircleCalculator.CalculateArea(rad);
                        double peri = CircleCalculator.CalculatePerimeter(rad);
                        CircleCalculator.DisplayResults(rad, peri, area);
                        break;
                    case 7:
                        Swap2Variables.Swap2Nums();
                        break;
                    case 8:
                        _1000RandomNums.DeclareArray();
                        break;
                    case 9:
                        RandThreeDigitNums.CreateArray();
                        break;
                    case 10:
                        Person.CreatePersons();
                        break;

                    default:
                        break;
                }






            } while (input != 11);

    {

            }

            //if (userChoice== "1")
            //{
            //    PrintHelloName.Print();
            //    return true;
            //}
            //else if (userChoice== "2")
            //{
            //    SumTwoNums.Add2Nums(3, 5);
            //    return true;
            //}
            //else if (userChoice=="3")
            //{
            //    Divide2Nums.DivideTwoNums(50,3);
            //    return true;
            //}
            //else if (userChoice=="4")
            //{
            //    Multiply2Nums.Mult2Nums(5, 25);
            //    return true;
            //}
            //else
            //{
            //    return true;
            //}

        }
    }
}
