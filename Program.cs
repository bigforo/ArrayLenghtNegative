using System;

namespace ArrayLenghtNegative
{
    class Program
    {
        public static unsafe void Main(string[] args)
        {
            int[] Array = new int[42];
            fixed (int* p = Array)
                p[-2] = -5;

            Console.WriteLine(Array.Length);
        }
    }
}
