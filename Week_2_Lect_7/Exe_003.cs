using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = Int32.Parse(Console.ReadLine());       

            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is neutral.");
            }

        }
    }
}
