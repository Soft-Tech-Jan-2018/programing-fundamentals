using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a1:d4} {a2:d4} {a3:d4} {a4:d4}");
        }
    }
}
