using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life"; //use quotation within code formatting
            //string myString = "What if I need a\nnew line"; //line break formatting
            //string myString = "Go to your c:\\drive"; //using \ as a symbol method 1
            //string myString = @"Go to your c:\drive"; //using \ as a symbol method 2

            //string myString = String.Format("{1} = {0}", "First", "Second"); //Order operation formatting

            //string myString = string.Format("{0:C}", 123.45); //Currency Formatting

            //string myString = string.Format("{0:N}", 1234567890); //Number Formating

            //string myString = string.Format(" Percentage {0:P}", .123); //Percentage formating

            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); //Phone formating

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14); //showing range
            //myString = myString.ToUpper(); //make all upper case
            //myString = myString.Replace(" ", "--"); //Replace
            //myString = myString.Remove(6, 14); //remove string

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, myString.Trim().Length);
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
