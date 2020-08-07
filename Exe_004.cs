using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int l = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < l ; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                l++;
                Console.WriteLine();                
            }
        }
    }
}
