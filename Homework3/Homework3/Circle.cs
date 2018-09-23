using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Circle : Shape
    {
        private double radius;
        
        public Circle(double radius) {
            if (radius > 0)
                this.radius = radius;
            else
                throw new ArgumentOutOfRangeException("Circle Radius");
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius > 0)
                    radius = value;
                else
                    throw new ArgumentOutOfRangeException("Circle Radius");
            }
        }

        public double Area() {
            return  Math.PI * radius * radius;  
        }

        public string info() {
            return $"Circle:radius={radius}.";
        }
    }
}
