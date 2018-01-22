using System;

namespace ElseIf
{
    public class ElseIf
    {
        public static void main(string args[])
        {
            int grade = 85;
            if (grade < 60)
            {
                Console.WriteLine('F');
            }
            else if (grade < 70)
            {
                Console.WriteLine('D');
            }
            else if (grade < 80)
            {
                Console.WriteLine('C');
            }
            else if (grade < 90)
            {
                Console.WriteLine('B');
            }
            else
            {
                Console.WriteLine('A');
            }
        }
    }
