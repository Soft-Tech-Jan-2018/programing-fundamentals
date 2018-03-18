using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            //read from the console width and height of a rectangle as floating point numbers
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //priny on the console area of the rectangle formatted to the 2nd character after the decimal point
            Console.WriteLine($"{width * height:F2}");
        }
    }
}