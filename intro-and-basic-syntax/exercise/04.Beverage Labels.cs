using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            //read from the console a food product name, volume, energy content per 100ml and sugar content per 100ml.
            string a = Console.ReadLine();
            int vol = int.Parse(Console.ReadLine());
            double kcal = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());

            //Calculate the energy and sugar content for the given volume and print them on the console.
            Console.WriteLine($"{vol}ml {a}:\n{vol * kcal / 100}kcal, {vol * g / 100}g sugars");
        }
    }
}