using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shapes
{
    internal class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width { get { return width; } set { width = value; } }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}
