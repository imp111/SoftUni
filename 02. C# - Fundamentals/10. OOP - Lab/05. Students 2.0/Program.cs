using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Students_2._0
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

                Student valueSet = new Student(firstName, lastName, age, homeTown);

                students.Add(valueSet);
                input = Console.ReadLine();
            }
        }
    }
}
