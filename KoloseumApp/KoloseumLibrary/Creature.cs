using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloseumLibrary
{
    public class Creature
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public double Speed { get; set; }

        public Creature() { }

        public virtual void Attack()
        {
            Console.WriteLine(this.Name + " is attacking!");
        }

        public virtual void CalculateDamage(int damage)
        {
            this.Health -= damage;
            if (this.Health < 0)
            {
                this.Health = 0;
                this.IsAlive = false;
            }
        }

    }
}
