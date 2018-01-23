using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Enter your name:"); //prompt
            String line = Console.ReadLine(); //Get string from user
            Console.Write("Hello " + line); //Greets person
            Console.ReadLine(); //Pauses to read to user
        }
    }
}
