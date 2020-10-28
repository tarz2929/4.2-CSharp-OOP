using System;
using System.Threading;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // First Call (From Main): 1, 10
            // Second Call (From First Call): 2, 10
            // Third Call (From Second Call): 3, 10
            // ...
            // Tenth Call (From Ninth Call): 10, 10
            // Eleventh Call (From Tenth Call): 11, 10 (skips the execution)
            RecursiveCount(1, 10);
        }
        static void RecursiveCount(int start, int end)
        {
            if (start <= end)
            {
                //Console.WriteLine(start);
                RecursiveCount(start + 1, end);
            }
        }
    }
}
