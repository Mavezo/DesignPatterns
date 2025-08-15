using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Mages
{
	public class FireMage : Mage
	{
		public FireMage(string name, int hp, int damage, int heal) : base(name, hp, damage, heal)
		{
		}

		public override void Attack()
		{
			Console.WriteLine("FireMage attacks!");
		}
		public void CastFireball()
		{
            Console.WriteLine("Fireball casted!");
        }

	}
}
