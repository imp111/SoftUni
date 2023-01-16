using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Animals
{
    internal class Animal
    {
        public string? Name;
        public int Age;
        public string Gender;
        public string? Sound { get; set; }
        public string? Type { get; set; }

        public Animal(string? name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void ProduceSound()
        {
            Console.WriteLine(Sound);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Type}");
            Console.WriteLine($"{Name} {Age} {Gender}");
        }
    }
}
