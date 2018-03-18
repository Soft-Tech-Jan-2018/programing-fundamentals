using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a * b:F2}");
        }
    }
}