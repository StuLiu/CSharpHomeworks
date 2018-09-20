using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic5
{
    //接口示例
    public interface Calculater
    {
       int area();
    }
    
    class Shape : Calculater
    {
        public int area() { return 100; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Calculater c = new Shape(); 
            Console.WriteLine(c.area());
        }
    }
}
