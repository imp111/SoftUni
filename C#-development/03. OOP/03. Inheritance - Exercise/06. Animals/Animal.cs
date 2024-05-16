using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Animals
{
    internal class Animal
    {
        private string name;
        private int age;
        private string gender;
        private string sound;
        private string type;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string Sound
        {
            get
            {
                return sound;
            }
            set
            {
                sound = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Animal(string? name, int age, string gender, string sound, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Sound = sound;
            this.Type = type;
        }

        public void ProduceSound()
        {
            Console.WriteLine(this.Sound);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{this.Type}");
            Console.WriteLine($"{this.Name} {this.Age} {this.Gender}");
        }
    }
}
