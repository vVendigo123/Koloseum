using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloseumLibrary
{
    public class Arena
    {
        public Creature[] Fighters { get; set; }
        private int? current;
        Random rand = new Random();
        public Arena(params Creature[] fighters)
        {
            if (fighters.Length != 2)
            {
                throw new NotImplementedException("Fight possible only between 2 fighters!");
            }
            else if (!fighters[0].IsAlive || !fighters[1].IsAlive)
            {
                throw new NotImplementedException("Dead fighters cannot fight!");
            }
            current = null;
            this.Fighters = new Creature[2];
            this.Fighters[0] = fighters[0];
            this.Fighters[1] = fighters[1];
        }
        public void Fight()
        {
            bool isOver = false;
            while(!isOver)
            {
                if(!Fighters[0].IsAlive || !Fighters[1].IsAlive)
                {
                    isOver = true;
                    Console.WriteLine("{0} wins!", (Fighters[0].IsAlive ? Fighters[0].Name : Fighters[1].Name));
                    continue;
                }
                WhoAttacks();
                Fighters[(int)current].Attack();
                Fighters[current == 0 ? 1 : 0].CalculateDamage(DealDamage());

            }
        }
        public void WhoAttacks()
        {
            current = current ?? (Fighters[0].Speed < Fighters[1].Speed ? 0 : 1);
            current = current == 1 ? 0 : 1;
        }
        public int DealDamage()
        {

            int maxDamage = Fighters[(int)current].Strength;
            int minDamage = (maxDamage - 10 <= 0) ? 0 : maxDamage - 10;
            int damage = rand.Next(minDamage, maxDamage+1);
            Console.WriteLine("Damage delt: {0}.", damage);
            
            return damage;
        }
    }
}
