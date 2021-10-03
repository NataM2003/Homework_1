using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------- Task 1 -------------------------------");
            Console.WriteLine();

            int a;

            Console.Write("Enter side of the square : ");
            a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.Write("Perimeter of the square : " + (a * 4));
                Console.WriteLine();
                Console.Write("Area of the square : " + (a * a));
            }
            else
            {
                Console.Write("Side of the sqare cannot be negative or 0. ");
            }
            Console.WriteLine();

            Console.WriteLine("------------------------------- Task 2 -------------------------------");
            Console.WriteLine();

            string name;
            int age;

            Console.Write("What is your name? ");
            Console.WriteLine();
            name = Console.ReadLine();

            Console.Write("How old are you, " + name + "?");
            Console.WriteLine();
            age = int.Parse(Console.ReadLine());
            Console.Write("You are " + name + ", " + age + " years old. ");
            Console.WriteLine();

            Console.WriteLine("------------------------------- Task 3 -------------------------------");
            Console.WriteLine();

            double r;
            double pi = 3.14;

            Console.Write("Enter radius of a circle : ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Lenth of a circle : " + (2 * pi * r) + "; " + "\n" + "Area of a circle : " + (pi * r * r) + "; " + "\n" + "Volume of a circle : " + (4 / 3 * pi * r * r * r));

            Console.ReadKey();
        }
    }
}
