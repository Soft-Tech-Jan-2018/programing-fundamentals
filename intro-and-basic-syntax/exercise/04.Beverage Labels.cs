using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            //read from the console a food product name, volume, energy content per 100ml and sugar content per 100ml.
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            //Calculate the energy and sugar content for the given volume and print them on the console.
            Console.WriteLine($"{volume}ml {name}:\n{volume * energyContent / 100}kcal, {volume * sugarContent / 100}g sugars");
        }
    }
}