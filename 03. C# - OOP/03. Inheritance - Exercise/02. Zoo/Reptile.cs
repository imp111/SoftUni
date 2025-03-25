using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Reptile : Animal
    {
        public string Name;

        public Reptile(string name) : base(name)
        {
            this.Name = name;
        }
    }
}