using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i < (int)Math.Sqrt(numInput) + 1; ++i)
                {
                    while (numInput % i == 0)
                    {
                        Console.WriteLine(i);
                        numInput /= i;
                    }
                }
                if (numInput != 1)
                {
                    Console.WriteLine(numInput);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
