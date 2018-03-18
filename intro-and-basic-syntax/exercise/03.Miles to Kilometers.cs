using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            double a = double.Parse(Console.ReadLine());


            Console.WriteLine($"{a * 1.60934:F2}");
        }
    }
}