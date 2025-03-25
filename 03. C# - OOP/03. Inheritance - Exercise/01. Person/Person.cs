using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance___Exercise
{
    internal class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();
        }
    }
}