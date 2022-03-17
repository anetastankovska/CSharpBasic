using SEDC.Oop.Class05.Exercises.Students.models;
using System;

namespace SEDC.Oop.Class05.Exercises.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Aneta", "WEB Development", "G3");
            Student student2 = new Student("Igor", "WEB Development", "G3");
            Student student3 = new Student("Aleksandar", "WEB Development", "G3");
            Student student4 = new Student("Stefan", "WEB Development", "G3");
            Student student5 = new Student("Maja", "WEB Development", "G3");

            Student [] studentsArr = new Student[5] { student1, student2, student3, student4, student5 };

            Console.WriteLine("Enter a student name:");
            string name = Console.ReadLine();
            Student student6 = null;

            foreach (Student student in studentsArr)
            {
                if (student.Name == name)
                {
                    student6 = student;
                    break;
                }
                
            }

            if(student6 != null)
            {
                student6.GetUserInformation();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadLine();
        }
    }
}
