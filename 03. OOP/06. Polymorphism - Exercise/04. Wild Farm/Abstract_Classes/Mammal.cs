using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal abstract class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion
        {
            get
            {
                return livingRegion;
            }
            set
            {
                livingRegion = value;
            }
        }

        public Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }
    }
}
