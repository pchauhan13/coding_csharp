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

            //bool isMale = true;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male.");
            //}
            //else if (isMale)
            //{
            //    Console.WriteLine("You are a male.");
            //}
            //else if (isTall)
            //{
            //    Console.WriteLine("You are tall.");
            //}
            //else
            //{
            //    Console.WriteLine("You are niether tall nor a male.");
            //}

            //Console.WriteLine(GetMax(5, 3));

            //Console.WriteLine("Please enter a day of week:");
            //var day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Sunday":
            //        Console.WriteLine("It's a holiday.");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("It's a weekend.");
            //        break;
            //    default:
            //        Console.WriteLine("It's a work day.");
            //        break;
            //}

            //int index = 1;
            //while (index < 11)
            //{
            //    Console.WriteLine(index++);
            //}

            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            int[,] numberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine(numberGrid[1, 1]);
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
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
