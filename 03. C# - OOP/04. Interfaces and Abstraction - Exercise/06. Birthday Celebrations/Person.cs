using _06._Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Birthday_Celebrations
{
    internal class Person : IDate 
    {
        public Person(string name, int age, string id, string date)
        {
            Name = name;
            Age = age;
            Id = id;
            Date = date;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Date { get; private set; }
    }
}
