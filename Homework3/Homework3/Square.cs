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
            if (width > 0) 
                this.width = width; 
            else
                throw new ArgumentOutOfRangeException("Square Width");
        }

        public double Width {
            get { return width; }
            set {
                if (value > 0) 
                    this.width = value; 
                else 
                    throw new ArgumentOutOfRangeException("Square Width");
            }
        }
        
        public double Area() { 
            return width * width;
        }

        public string info() {
            return $"Square:width={width}.";
        }
    }
}
