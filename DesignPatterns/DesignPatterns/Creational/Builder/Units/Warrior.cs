using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DesignPatterns.Creational.Builder.Base;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Units
{
    public class Warrior : Unit
    {
        public Warrior(string name, int health, int damage, string weapon)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Weapon = weapon;
            Class = "Warrior";
        }
    }
}
