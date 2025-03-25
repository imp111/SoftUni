using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}"));

            return stringBuilder.ToString();
        }
    }
}