using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal: ");
            int decimalNum = Int32.Parse(Console.ReadLine());

            string binary = Convert.ToString(decimalNum, 2);

            Console.WriteLine(binary);
        }
    }
}