using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.IceUnits
{
	public class IceMage: Mage
	{
		public IceMage(string name, int hp, int damage, int heal) : base(name, hp, damage, heal)
		{
		}

		public override void Attack()
		{
			Console.WriteLine("IceMage attacks!");
		}

		public void Healing()
		{
            Console.WriteLine("IceMage heals!");
        }
		public void CastBlizzard()
		{
			Console.WriteLine("IceMage casted blizzard!");
		}
	}
}
