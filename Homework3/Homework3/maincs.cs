using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            ArrayList  shapes = new ArrayList();
            shapes.Add(sf.createTriangle(3, 4, 5));
            shapes.Add(sf.createCircle(10));
            shapes.Add(sf.createSquare(1.5));
            shapes.Add(sf.createRectangle(6, 8));
            foreach(Shape shape in shapes) {
                shape.Area();
            }
        }
    }
}
