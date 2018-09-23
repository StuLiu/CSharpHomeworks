using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class ShapeFactory
    {
        public Shape createSquare(double width) {
            return new Square(width);
        }

        public Shape createCircle(double radius) {
            return new Circle(radius);
        }

        public Shape createRectangle(double length, double width) {
            return new Rectangle(length, width);
        }

        public Shape createTriangle(double a, double b, double c) {
            return new Triangle(a, b, c);            
        }
    }
}
