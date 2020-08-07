using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1, val;
            while (i < 25)
            {
                val = i + j;
                j = i;
                i = val;
                Console.WriteLine(val);
            }
        }
    }
}
