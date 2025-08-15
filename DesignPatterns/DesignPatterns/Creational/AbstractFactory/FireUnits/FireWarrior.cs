using DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.FireUnits
{
	public class FireWarrior : Warrior
	{
		public FireWarrior(string name, int hp, int damage) : base(damage, hp, name)
		{
		}
		public override void Attack(Unit target)
		{
            Console.WriteLine("Fire Warrior attacks!");
        }
	}
}
