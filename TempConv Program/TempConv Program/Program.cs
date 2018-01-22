using System;

namespace TempConv_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            string input;

            Console.WriteLine("Temperature in F:");
            input = Console.ReadLine();
            fahrenheit = double.Parse(input);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temperature in C is: " + celsius);
            Console.ReadLine();
        }
    }
}
