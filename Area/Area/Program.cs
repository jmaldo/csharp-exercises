using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            area = (3.14) * r * r;
            Console.WriteLine("The Area of circle of given radius is=" + area);
            Console.ReadLine();
        }
    }
}