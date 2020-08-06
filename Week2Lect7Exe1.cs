using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are even.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} aren't even.");
            }

        }
    }
}
