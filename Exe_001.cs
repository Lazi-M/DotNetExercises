using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 100; x++)
            {
                int primeN = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        primeN++;

                    if (primeN == 2)
                        break;
                }
                if (primeN != 2)
                    Console.WriteLine(x);
            }

        }
    }
}
