using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrInts length at least have one element.
            int[] arrInts= { 1, 2, 3, 11, 9, 5, -5, -9, 24 };
            
            int maxInt = arrInts[0];
            int minInt = arrInts[0];
            int sum = 0;
            for (int i = 0; i < arrInts.Length; ++i)
            {
                maxInt = arrInts[i] > maxInt ? arrInts[i] : maxInt;
                minInt = arrInts[i] < minInt ? arrInts[i] : minInt;
                sum += arrInts[i];
            }

            Console.WriteLine("Max:" + maxInt);
            Console.WriteLine("Min:" + minInt);
            Console.WriteLine("Sum:" + sum);
            Console.WriteLine("Avg:" + (double)sum / arrInts.Length);
        }
    }
}
