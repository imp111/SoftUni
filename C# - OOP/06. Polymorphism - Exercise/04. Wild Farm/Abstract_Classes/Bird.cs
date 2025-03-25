using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal abstract class Bird : Animal
    {
        private double wingSize;

        public double WingSize
        {
            get
            {
                return wingSize;
            }
            set
            {
                wingSize = value;
            }
        }

        public Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }
    }
}
