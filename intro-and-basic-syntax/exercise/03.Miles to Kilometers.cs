//Confirmed from <bubalik>
using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
			//We get the miles from the console input
            double a = double.Parse(Console.ReadLine());
            //We convert the miles into kilometers and print the outcome
            Console.WriteLine($"{a * 1.60934:F2}");
        }
    }
}