using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);                    
                }
                a++;
            }
            while (a < 1001);
        }
    }
}
