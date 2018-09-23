using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square : Shape
    {
        private double width;

        public Square(double width) {
            this.width = width;
        }

        public double Area() {
            double area = width * width;
            Console.WriteLine($"Square:width={width},area={area}.");
            return area;
        }
    }
}
