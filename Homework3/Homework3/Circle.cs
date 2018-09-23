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

        public Circle(double radius) { this.radius = radius; }

        public double Area() {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Circle:radius={radius},are={area}.");
            return area;
        }
    }
}
