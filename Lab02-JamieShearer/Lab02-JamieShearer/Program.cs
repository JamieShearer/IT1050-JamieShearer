using System;

namespace Lab02_JamieShearer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer:");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");

            string x = "1";
            string y = "2";
            string z = "3";

            Console.WriteLine($"Sum is {x + y}*{z +10}");

            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");
        }
    }
}
