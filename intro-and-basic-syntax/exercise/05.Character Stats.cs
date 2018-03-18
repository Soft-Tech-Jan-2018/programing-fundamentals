using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            string a = Console.ReadLine();
            int curHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int curMP = int.Parse(Console.ReadLine());
            int maxMP = int.Parse(Console.ReadLine());

            string hp = new string('|', curHP);
            string mp = new string('|', curMP);
            string hpd = new string('.', (maxHP - curHP));
            string mpd = new string('.', (maxMP - curMP));



            Console.WriteLine($"Name: {a}\nHealth: |{hp}{hpd}|\nEnergy: |{mp}{mpd}|");
        }
    }
}