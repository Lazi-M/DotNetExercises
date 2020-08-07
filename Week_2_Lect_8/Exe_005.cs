using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} ^ 3 = " + (i * i * i));
            }
        }
    }
}
