using DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.IceUnits
{
	public class IceMage : Mage
	{
		public IceMage(string name, int hp, int damage, int heal) : base(name, hp, damage, heal)
		{
		}

		public override void Attack(Unit target)
		{
			//int resultHp = target.Health - this.Damage > 0 ? target.Health - this.Damage : 0;
			//Console.WriteLine($"${this.Name} attacks with fire damage!");
			//Console.WriteLine($"{target.Health} -> {resultHp}");
			//target.Health = resultHp;
			//BAD PRACTICE
			Console.WriteLine("IceMage attacks!");
		}

		public override void Healing(Unit target)
		{
            Console.WriteLine("IceMage heals!");
        }
	}
}
