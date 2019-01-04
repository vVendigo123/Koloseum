using KoloseumLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloseumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w Koloseum!");
            Creature[] wojownicy = new Creature[2];
            wojownicy[0] = new Creature()
            {
                Health = 100,
                IsAlive = true,
                Name = "Krokodyl",
                Strength = 3

            };
            wojownicy[1] = new Creature()
            {
                Health = 70,
                IsAlive = true,
                Name = "Wąż",
                Strength = 18

            };
            Arena arena = new Arena(wojownicy);
            arena.Fight();
            Console.ReadKey();
        }
    }
}
