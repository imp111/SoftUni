using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shapes
{
    internal abstract class Shape
    {
        public double CalculatePerimeter(double height, double width)
        {
            return 2 * (height + width);
        }

        public double CalculateArea(double height, double width) 
        {
            return height * width;
        }

        public virtual string Draw()
        {
            return "";
        }
    }
}
