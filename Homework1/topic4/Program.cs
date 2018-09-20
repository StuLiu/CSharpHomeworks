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
        static void Main(string[] args)
        {
            //int[,] a = { { 1, 2, 5, 4 }, { 3, 4, 0, 5 }, { 5, 6, 7, 5 } };
            //int[][] tt = new int[4][];
            //tt[0] = new int[2];
            //tt[1] = new int[4];
            //tt[0][1] = 1;
            //Console.WriteLine(a.Length + "," + a.GetLength(0) + "," + a.GetLength(1));    //  总长度,第一维长度，第二维长度
            //Console.WriteLine(tt.Length );    //  总长度

            IndexDemo a = new IndexDemo();
            a[1] = "hello";
            Console.WriteLine(a[1]);
            Console.WriteLine(a[3]);

        }
    }
}
