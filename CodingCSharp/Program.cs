using System;

namespace CodingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.Print();

            //var x = Console.ReadLine();
            //Console.WriteLine(x);
            //Console.WriteLine($"Hello {x}");

            //int y = 6;
            //Console.WriteLine(y);

            //String str = "Prashant";
            //Console.WriteLine(str + " is weird");

            //Console.WriteLine(cube(5));

            bool isMale = true;

            if (isMale)
            {
                Console.WriteLine("You are a male.");
            }
            else
            {
                Console.WriteLine("You are not a male.");
            }
        }

        static double cube (int number)
        {
            return number * number * number;
        }

        void Print()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best Friend!");
        }
    }
}
