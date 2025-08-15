using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base
{
    public abstract class Mage : Unit
    {
        public int Damage { get; }
        public int Heal { get; }
        protected Mage(string name, int hp, int damage, int heal) : base(name, hp)
        {
            Damage = damage;
            Heal = heal;
        }
        public abstract void Healing(Unit target);
        public abstract void Attack(Unit target);


    }
}
