using DesignPatterns.DesignPatterns.Creational.Builder.Base;
using DesignPatterns.DesignPatterns.Creational.Builder.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Builders
{
	public class WarriorBuilder : IUnitBuilder
	{
		private string name;
		private int health;
		private int damage;
		private string weapon;

		public IUnitBuilder SetName(string name) { this.name = name; return this; }
		public IUnitBuilder SetHP(int health) { this.health = health; return this; }
		public IUnitBuilder SetDamage(int damage) { this.damage = damage; return this; }
		public IUnitBuilder SetWeapon(string weapon) { this.weapon = weapon; return this; }

		public Unit Build()
		{
			return new Warrior(name, health, damage, weapon);
		}
	}
}
