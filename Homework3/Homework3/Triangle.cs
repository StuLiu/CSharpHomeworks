using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle : Shape {
        
        private double edge1;

        private double edge2;

        private double edge3;

        public Triangle(double a, double b, double c) {
            if (judge(a, b, c)) {
                edge1 = a;
                edge2 = b;
                edge3 = c;
            } else {
                throw new ArgumentOutOfRangeException("Triangle Edges");
            }
        }

        public double Edge1 {
            get { return edge1; }
            set {
                if (judge(value, edge2, edge3))
                    edge1 = value;
                else
                    throw new ArgumentOutOfRangeException("Triangle Edge1");
            }
        }

        public double Edge2 {
            get { return edge2; }
            set {
                if (judge(value, edge1, edge3))
                    edge2 = value;
                else
                    throw new ArgumentOutOfRangeException("Triangle Edge2");
            }
        }
        public double Edge3 {
            get { return edge3; }
            set {
                if (judge(value, edge1, edge2))
                    edge3 = value;
                else
                    throw new ArgumentOutOfRangeException("Triangle Edge3");
            }
        }

        public string Info {
            get {
                return $"Triangle:edge1={edge1},edge2={edge2},edge3={edge3}.";
            }
        }

        public double GetArea() {
            double p = (edge1 + edge2 + edge3) / 2;
            return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
        }

        // judge three edges of a triangle whether they are legal or not
        // if legal return true, otherwise return false
        private bool judge(double a, double b, double c) {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b <= c || b + c <= a || a + c <= b)
                return false;
            return true;
        }
    }
}
