using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! In this program i need some information about you: ");
            Console.WriteLine("Let's start!");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter your e-mail adress: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender: ");
            Console.WriteLine("Press M for male, F for Female: ");
            char gender = char.Parse(Console.ReadLine());
        }
    }
}
