using System;
using System.Collections.Generic;

namespace studio_countingcharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var test_string = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            var dict = new Dictionary<char, int>();
            foreach (var x in test_string)
            {
                if (!dict.ContainsKey(x))
                    dict[x] = 1;
                else
                    dict[x]++;
            }
            foreach (var x in dict.Keys)
            {
                Console.WriteLine($"{x} : {dict[x]}");
                Console.ReadLine();
            }

        }
    }
}
