using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExercises
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static void CreatePersons()
        {
            Teacher t1 = new Teacher("Lara", 42, "laraw");
            Teacher t2 = new Teacher("Riannan", 38, "riannanb");
            Teacher t3 = new Teacher("Mel", 42, "meld");
            Teacher t4 = new Teacher("Kirky", 42, "kirkyc");
            Teacher t5 = new Teacher("Ali", 52, "alif");
            Student s1 = new Student("Sam", 10, 1234);
            Student s2 = new Student("Orrie", 8, 1235);
            Student s3 = new Student("Josh", 11, 1236);
            Student s4 = new Student("Dan", 9, 1237);
            Student s5 = new Student("Rome", 9, 1238);

            Person[] person = 
            {
                    t1,
                    t2,
                    t3,
                    t4,
                    t5,
                    s1,
                    s2,
                    s3,
                    s4,
                    s5
            };
            //ERROR HERE - CANT PRINT ARRAY DETAILS FOR STUDENT OR TEACHER
            foreach (Teacher x in person)
            {
                Console.WriteLine("\nName: {0}\nAge: {1}\nStaff Login: {2}",x.Name, x.Age, x.StaffLoginName); 
            }

            foreach (Student x in person)
            {
                Console.WriteLine("\nName: {0}\nAge: {1}\nStudent ID: {2}", x.Name, x.Age, x.StudentId);
            }

            Console.ReadLine();
        }
    }

    public class Teacher : Person
    {
        public string StaffLoginName { get; set; }

        public Teacher (string _name, int _age, string _staffLoginName)
        {
            Name = _name;
            Age = _age;
            StaffLoginName = _staffLoginName;
        }


    }

    public class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string _name, int _age, int _studentId)
        {
            Name = _name;
            Age = _age;
            StudentId = _studentId;
        }

    }


}
