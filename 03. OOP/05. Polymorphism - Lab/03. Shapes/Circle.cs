using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shapes
{
    internal class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double raius) 
        {
            this.Radius = raius;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
