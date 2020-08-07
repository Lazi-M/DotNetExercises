using System;

namespace DotNetExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program drawDiamond = new Program();
            drawDiamond.SetSize();
            drawDiamond.SetShape();
        }

        int side;
        public int Side
        {
            get { return side; }
            private set { side = value > 2 ? value : 2; }
        }

        public void SetSize()
        {
            Console.WriteLine("Set the size of shorter side: ");
            Side = Int32.Parse(Console.ReadLine());
        }

        public void SetShape()
        {
            for (int i = 0; i < Side * 2 - 1; i++)
            {
                for (int j = 0; j < Side * 2 - 1; j++)
                {
                    if (i < Side)
                    {
                        if ((i + j) >= Side - 1 && (i + j) < Side + (i * 2))
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    else
                    {
                        if (i + j < Side * 3 - 2 && i + j > i * 2 - Side)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}