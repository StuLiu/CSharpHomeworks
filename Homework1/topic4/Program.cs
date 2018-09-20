using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4
{
    //索引使用样例
    public class IndexDemo
    {
        private string[] strs = new string[3];
        public string this[int index]
        {
            get {
                if(index < strs.Length && index >= 0)
                {
                    return strs[index];
                } 
                return "index out of range";
            }
            set {
                strs[index] = value;
            }
        }

    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    IndexDemo a = new IndexDemo();
        //    a[1] = "hello";
        //    Console.WriteLine(a[1]);
        //    Console.WriteLine(a[3]);
        //}
        static void Main(string[] args)
        {
            try
            {
                int numInput1 = Convert.ToInt32(Console.ReadLine());
                int numInput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{numInput1}*{numInput2}={numInput1 * numInput2}");
            }
            catch(Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
