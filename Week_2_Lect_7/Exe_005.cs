using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = Int32.Parse(Console.ReadLine());
                        
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("In your age you can be Deputy and Prime");
            }
            else if (age >= 21 && age < 35)
            {
                Console.WriteLine("In your age you can be Deputy, Prime and Senator");
            }
            else if (age >= 21)
            {
                Console.WriteLine("In your age you can be Deputy, Prime, Senator and President");
            }
            else
            {
                Console.WriteLine("You are to young to be in government");
            }
        }
    }
}

/*
 * Poseł     Deputy     21
 * Premier   Prime      21
 * Senator   Senator    30
 * Prezydent President  35
 */