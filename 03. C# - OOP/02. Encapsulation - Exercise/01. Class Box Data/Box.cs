using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Encapsulation___Exercise
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length 
        {
            get { return this.length; } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be negative or zero!");
                }

                this.length = value;
            } 
        }

        public double Width {  
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be negative or zero!");
                }

                this.width = value;
            }
        }
        public double Height {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be negative or zero!");
                }

                this.height = value;
            }
        }

        public void SurfaceArea()
        {
            Console.WriteLine($"Surface Area - {(2 * length * width) + (2 * length * height) + (2 * width * height):F2}");
        }

        public void LateralSurfaceArea()
        {
            Console.WriteLine($"Lateral Surface Area - {(2 * length * height) + (2 * width * height):F2}");
        }

        public void Volume()
        {
            Console.WriteLine($"Volume - {length * width * height:F2}");
        }
    }
}
