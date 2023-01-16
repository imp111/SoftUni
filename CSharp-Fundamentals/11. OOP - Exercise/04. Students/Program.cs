using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:F2}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>(numberOfStudents);
            string[] input;
            for (int i = 0; i < numberOfStudents; i++)
            {
                input = Console.ReadLine().Split(' ');

                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, secondName, grade);
                studentList.Add(student);
            }

            studentList = studentList.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join("\n", studentList));
        }
    }
}