using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base
{
	public class Mage : Unit
	{
		public int Damage { get; }
		public int Heal { get; }
		public Mage(string name, int hp, int damage, int heal) : base(name, hp)
		{
			Damage = damage;
			Heal = heal;
		}
		public virtual void Attack()
		{
            Console.WriteLine("Mage Attacks!");
        }

	}
}