using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    class CircleCalculator
    {

        public static double GetUserRadius()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine("Radius: {0}",radius);
            return radius;
        }

        public static double CalculatePerimeter(double radius)
        {
            double perimeter = Math.PI * (radius * radius);
            //Console.WriteLine("Perimeter = {0}",perimeter);
            return perimeter;
            
        }

        public static double CalculateArea(double radius)
        {
            double area = (2 * Math.PI) * radius;
            //Console.WriteLine("Area = {0}", area);
            return area;
        }

        public static void DisplayResults(double radius, double perimeter, double area)
        {
            Console.WriteLine("Your chosen radius: {0}", radius);
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);
            Console.ReadLine();
        }
    }
}
