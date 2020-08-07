using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers and press enter after each one of them:");
            int firstNum = Int32.Parse(Console.ReadLine());
            int secondNum = Int32.Parse(Console.ReadLine());
            int thirdNum = Int32.Parse(Console.ReadLine());

            int result = Math.Max(firstNum, Math.Max(secondNum, thirdNum));

            Console.WriteLine($"Max from {firstNum}, {secondNum} and {thirdNum} is {result}");
        }
    }
}
