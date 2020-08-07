using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double secondNum = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter third number");
            double thirdNum = double.Parse(Console.ReadLine());

            if ((firstNum * firstNum) + (secondNum * secondNum) == (thirdNum * thirdNum))
            {
                Console.WriteLine("You can build a triangle");
            }
            else
            {
                Console.WriteLine("You can't build triangle");
            }
        }
    }
}
