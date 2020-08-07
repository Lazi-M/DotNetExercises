using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's the temperature there?");
            double tempN = double.Parse(Console.ReadLine());

            if (tempN < 0)
            {
                Console.WriteLine("It's fucken cold there");
            }
            else if (tempN > 0 && tempN <10)
            {
                Console.WriteLine("Wow, it must be cold");
            }
            else if (tempN > 10 && tempN < 20)
            {
                Console.WriteLine("Well it's cool");
            }
            else if (tempN > 20 && tempN < 30)
            {
                Console.WriteLine("It's just right");
            }
            else if (tempN > 30 && tempN < 40)
            {
                Console.WriteLine("It's so hot");
            }
            else if (tempN >= 40)
            {
                Console.WriteLine("Can't stand it, buying tickets to Alaska");
            }


        }
    }
}
