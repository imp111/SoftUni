using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Bear : Mammal
    {
        public string Name;

        public Bear(string name) : base(name)
        {
            Name = name;
        }
    }
}