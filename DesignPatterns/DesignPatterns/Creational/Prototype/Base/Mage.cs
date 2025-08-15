using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Base
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
		public Mage(Mage prototype) : base(prototype)
		{
			this.Heal = prototype.Heal;
			this.Damage = prototype.Damage;
		}
		public virtual void Attack()
		{
            Console.WriteLine("Mage Attacks!");
        }
		public override Unit Clone() 
		{
			return new Mage(this);
		}
	}
}