using System;
using System.Linq.Expressions;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this program will check if you can join our college");
            
            Console.WriteLine("Enter your points from Maths: ");
            int mathNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your points from Science: ");
            int scienceNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your points from Chemistry: ");
            int chemistryNum = Int32.Parse(Console.ReadLine());

            if ((mathNum + scienceNum + chemistryNum > 180) || (mathNum + scienceNum > 150) || (mathNum + chemistryNum > 150))
            {
                Console.WriteLine("You can join our college.");
            }
        }
    }
}
