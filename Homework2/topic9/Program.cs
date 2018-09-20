using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100;
            // for i >= 2 ,if i isn't an prime number,flag[i] is equal to 1;
            int[] flag = new int[N + 1];

            for(int num = 2; num <= N; ++num)
                for(int i = 2; i <= N; ++i)
                    if (i % num == 0 && i / num != 1)
                        flag[i] = 1;
            for (int i = 2; i <= N; ++i)
                if (flag[i] == 0)
                    Console.WriteLine(i);
        }
    }
}
