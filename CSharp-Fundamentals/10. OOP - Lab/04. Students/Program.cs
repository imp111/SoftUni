using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstname, string lastname, int age, string hometown)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            HomeTown = hometown;
        }
    }

    class Program
    {
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student var in students)
            {
                if (var.FirstName == firstName && var.LastName == lastName)
                {
                    existingStudent = var;
                }
            }

            return existingStudent;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student newList = GetStudent(students, firstName, lastName);

                    newList.FirstName = firstName;
                    newList.LastName = lastName;
                    newList.Age = age;
                    newList.HomeTown = homeTown;
                }
                else
                {
                    Student valueSet = new Student(firstName, lastName, age, homeTown);
                    students.Add(valueSet);
                }
                
                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student var in students)
            {
                if (var.HomeTown == filterCity)
                {
                    Console.WriteLine("{0} {1} is {2} years old.", var.FirstName, var.LastName, var.Age);
                }
            }
        }
    }
}
