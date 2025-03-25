using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Interfaces_and_Abstraction
{
    internal class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}
