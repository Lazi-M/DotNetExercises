using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height in cm:");
            double heightNum = Double.Parse(Console.ReadLine());

            if (heightNum > 100 && heightNum < 160)
            {
                Console.WriteLine("You must be a dwarf");
            }
            else if (heightNum > 160 && heightNum < 180)
            {
                Console.WriteLine("Your height is average size, don't worry");
            }
            else if (heightNum > 180)
            {
                Console.WriteLine("Wow! Big daddy cool Diesel");
            }
            else
            {
                Console.WriteLine("Stuart Little is that you?");
            }
        }
    }
}
