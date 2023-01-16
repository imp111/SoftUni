﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
            Type = "Dog";
            Sound = "Woof!";
        }
        
    }
}
