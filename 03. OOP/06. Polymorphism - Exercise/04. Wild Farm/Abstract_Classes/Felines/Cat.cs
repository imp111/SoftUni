using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
    }
}
