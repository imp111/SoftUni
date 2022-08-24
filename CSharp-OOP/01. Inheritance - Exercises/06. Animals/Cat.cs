using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
            Type = "Cat";
            Sound = "Meow meow";
        }
    }
}
