using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public double Area() {
            double area = width * length;
            Console.WriteLine($"Rectangle:length={length},width={width},area={area}.");
            return area;
        }
    }
}
