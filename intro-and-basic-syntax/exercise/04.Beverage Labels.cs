using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            string a = Console.ReadLine();
            int vol = int.Parse(Console.ReadLine());
            double kcal = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());


            Console.WriteLine($"{vol}ml {a}:\n{vol * kcal / 100}kcal, {vol * g / 100}g sugars");
        }
    }
}