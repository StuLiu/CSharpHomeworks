using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle : Shape
    {
        private double edge1;
        private double edge2;
        private double edge3;

        public Triangle(double a, double b, double c) {
            edge1 = a;
            edge2 = b;
            edge3 = c;
        }

        public double Area() {
            double p = (edge1 + edge2 + edge3) / 2;
            double area = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            Console.WriteLine($"Triangle:edge1={edge1},edge2={edge2},edge3={edge3},area={area}.");
            return area;
        }
    }
}
