using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string inputTxt = Console.ReadLine();
            string outputTxt = "";

            int x = inputTxt.Length;

            do
            {
                x--;
                outputTxt += inputTxt[x];
            }
            while (x > 0);

            Console.WriteLine($"Your text backwards is: {outputTxt}");
        }
    }
}