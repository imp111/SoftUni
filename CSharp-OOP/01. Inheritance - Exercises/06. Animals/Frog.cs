using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Animals
{
    internal class Frog : Animal 
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
            Type = "Frog";
            Sound = "Ribbit";
        }
    }
}
