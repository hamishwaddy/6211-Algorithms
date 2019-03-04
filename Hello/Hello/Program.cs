using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello");
            Console.WriteLine("Sam & Orrin Wadsworth");

            Console.WriteLine();

            int num1 = 74;
            int num2 = 36;
            int sum = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);

            int num3 = 50;
            int num4 = 3;
            int sumDiv = num3 / num4;
            Console.WriteLine("\n{0} / {1} = {2}", num3, num4, sumDiv);
            

            Console.Write("Input first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int output = firstNum * secondNum;
            Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, output);
            

            Console.Write("Input a number: ");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int total = userInput * i;
                Console.WriteLine("{0} x {1} = {2}", i, userInput, total);
            }
            

            Console.Write("Input a number - the radius: ");
            double radius = double.Parse(Console.ReadLine());
            
            double perimeter = (2 * Math.PI) * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter: {0}\nArea: {1}",perimeter, area);
            

            int numA = 10;
            int numB = 20;
            int tempNum;

            Console.WriteLine("Before swap\tA = {0}\tB = {1}",numA,numB);

            tempNum = numA;
            numA = numB;
            numB = tempNum;
            Console.WriteLine("After swap\tA = {0}\tB = {1}",numA,numB);
            

            Random rand = new Random();
            int[] array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1000,10000);
                Console.Write(array[i] + " ");
            }
            
    
            //NEDDS TO BE FIXED - HOW TO CREATE UNIQUE RNDOM NUMS AND THEN WRITE TO CONSOLE USING EXACT NUMBER OF COLUMNS
            Random rand = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                int num;
                int j;
                bool unique;
                do
                {
                    unique = true;
                    num = rand.Next(100, 1000);

                    for (j = 0; j < i; j++)
                    {
                        if (num == array[j])
                        {
                            unique = false;
                            break;
                        }
                    }
                } while (!unique);
                array[i] = num;
            }

            Array.Sort(array);

            foreach(int n in array)
                Console.WriteLine(n + " ");
                */


            Teacher t1 = new Teacher("Bob", 25, "bobs");
            Teacher t2 = new Teacher("Jacob", 35, "jacobv");
            Teacher t3 = new Teacher("Lara", 42, "laraw");
            Teacher t4 = new Teacher("Mel", 45, "meld");
            Teacher t5 = new Teacher("Kirsten", 51, "kirstenb");

            Student s1 = new Student("Sam", 10, 1234);
            Student s2 = new Student("Orrin", 8, 1235);
            Student s3 = new Student("Dan", 9, 1236);
            Student s4 = new Student("Josh", 11, 1237);
            Student s5 = new Student("James", 13, 1238);

            Person[] peopleArray = new Person[] 
            {
                s1,
                s2,
                s3,
                s4,
                s5,
                t1,
                t2,
                t3,
                t4,
                t5
            };

            //for (int i = 0; i < peopleArray.Length; i++)
            //{
            //    Console.WriteLine(  peopleArray[i].Login);
            //}

            //for(int i = 0;i<5;i++)
            //{
            //    Console.WriteLine("Name: {0}\nAge: {1}",peopleArray[i].Name, peopleArray[i].Age);
            //    Console.WriteLine("Login: {0}", peopleArray[i].);
            //}

            foreach (Person x in peopleArray)
            {
                if (x.GetType() == typeof(Teacher))
                {
                    Teacher y = (Teacher)x;
                    Console.WriteLine("Name: {0}\nAge: {1}\nStaff Login: {2}", y.Name, y.Age, y.StaffLogin);
                }
                else
                {
                    Student y = (Student)x;
                    Console.WriteLine("Name: {0}\nAge: {1}\nStudent ID: {2}", y.Name, y.Age, y.StudentId);
                }
                
            }





            Console.ReadLine();
        }
    }
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
    }

    public class Teacher : Person
    {
        public string StaffLogin { get; set; }

        //CONSTRUCTOR
        public Teacher(string _name, int _age, string _login) : base(_name, _age)
        {
            StaffLogin = _login;
        }
    }

    public class Student : Person
    {
        public Student(string _name, int _age, int studentId) : base (_name, _age)
        {
            StudentId = studentId;
        }

        public int StudentId { get; set; }
    }
}
