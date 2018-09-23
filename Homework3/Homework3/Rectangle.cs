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
            if (length > 0 && width > 0) {
                this.length = length;
                this.width = width;
            }
            else {
                throw new ArgumentOutOfRangeException("Rectangle Width or Length");
            }
        }

        public double Length {
            get { return length; }
            set {
                if (value > 0)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("Rectangle Length");
            }
        }

        public double Width {
            get { return width; }
            set {
                if (value > 0)
                    width = value;
                else
                    throw new ArgumentOutOfRangeException("Rectangle Width");
            }
        }
        
        public double Area() {
            return length * width;
        }

        public string info() {
            return $"Rectangle:length={length},width={width}.";
        }
    }
}
