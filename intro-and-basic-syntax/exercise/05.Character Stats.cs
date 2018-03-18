//Confirmed from <bubalik>
using System;
namespace Debit
{
    class Program
    {
        static void Main(String[] Args)
        {
            //We get the character name and stats via console input in the next 5 lines
            string a = Console.ReadLine();
            int curHP = int.Parse(Console.ReadLine()); 
            int maxHP = int.Parse(Console.ReadLine());
            int curMP = int.Parse(Console.ReadLine());
            int maxMP = int.Parse(Console.ReadLine());

            string hp = new string('|', curHP); //string represents bars of remaining Health
            string mp = new string('|', curMP); //string represents bars of remaining Energy
            string hpd = new string('.', (maxHP - curHP)); //string represents depleted Health
            string mpd = new string('.', (maxMP - curMP)); //string represents depleted Energy


            //We print the character's name and stats
            Console.WriteLine($"Name: {a}\nHealth: |{hp}{hpd}|\nEnergy: |{mp}{mpd}|");
        }
    }
}