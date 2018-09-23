using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square : Shape {

        private double width;

        public Square(double width) {
            Width = width;
        }

        public string Info {
            get {
                return $"Square:width={width}.";
            }
        }

        public double Width {
            get { return width; }
            set {
                if (value > 0) 
                    width = value; 
                else 
                    throw new ArgumentOutOfRangeException("Square Width");
            }
        }
        
        public double GetArea() { 
            return width * width;
        }
    }
}
