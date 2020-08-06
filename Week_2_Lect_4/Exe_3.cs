using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 2;
            double length = 4;
            double diagonal = Math.Sqrt(Math.Pow(2, width) + Math.Pow(2, length));
            Console.WriteLine($"The diagonal of the rectangle for the sides {width} and {length} is {diagonal} ");
        }
    }
}