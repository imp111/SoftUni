using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public string? Message { get; set; }

        public Student(string? name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInformation(Student student)
        {
            if (student.Grade >= 5.50)
            {
                student.Message = "Excelent student";
            }
            else if (student.Grade >= 3.00)
            {
                student.Message = "Average student";
            }
            else
            {
                student.Message = "Very nice person";
            }

            Console.WriteLine($"{student.Name} is {student.Age} years old. {student.Message}.");
        }
    }
}
