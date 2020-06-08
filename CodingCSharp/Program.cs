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
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale)
            {
                Console.WriteLine("You are a male.");
            }
            else if (isTall)
            {
                Console.WriteLine("You are tall.");
            }
            else
            {
                Console.WriteLine("You are niether tall nor a male.");
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
