using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter year:");
            int yearNum = Int32.Parse(Console.ReadLine());

            if ((yearNum % 4 == 0) && (yearNum % 100 != 0) || (yearNum % 400 == 0))
            {
                Console.WriteLine($"{yearNum} is a leap-year");
            }
            else
            {
                Console.WriteLine($"{yearNum} is not a leap-year");
            }
        }
    }
}
