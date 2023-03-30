using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }
    }
}
