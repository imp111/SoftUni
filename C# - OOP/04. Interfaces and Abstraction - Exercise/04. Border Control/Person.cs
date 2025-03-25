using _04._Border_Control.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Border_Control
{
    internal class Person : IDentity
    {
        public string Name { get; private set; }
        public string Id { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age, string id)
        {
            Name = name;
            Id = id;
            Age = age;
        }   
    }
}
