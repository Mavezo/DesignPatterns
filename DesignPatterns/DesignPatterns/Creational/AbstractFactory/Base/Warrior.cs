using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base
{
    public abstract class Warrior : Unit
    {
        public int Damage { get; }
        protected Warrior(int damage, int hp, string name) : base(name, hp)
        {
            Damage = damage;
        }
        public abstract void Attack(Unit target);
    }
}
