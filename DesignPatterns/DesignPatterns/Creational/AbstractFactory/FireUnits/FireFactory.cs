using DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.FireUnits
{
	public class FireFactory : IUnitFactory
	{
		public Mage CreateMage()
		{
			return new FireMage("Fire Mage", 100, 20, 20);
		}

		public Warrior CreateWarrior()
		{
			return new FireWarrior("Fire Warrior", 150, 10);
		}
	}
}
