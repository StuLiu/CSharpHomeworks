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
            Radius = radius;
        }

        public string Info {
            get {
                return $"Circle:radius={radius}.";
            }
        }

        public double Radius {
            get { return radius; }
            set {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentOutOfRangeException("Circle Radius");
            }
        }

        public double GetArea() {
            return  Math.PI * radius * radius;  
        }
    }
}
