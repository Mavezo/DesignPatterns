using DesignPatterns.DesignPatterns.Creational.AbstractFactory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.IceUnits
{
	public class IceFactory : IUnitFactory
	{
		public Mage CreateMage()
		{
			return new IceMage("Ice Mage", 150, 15, 35);
		}

		public Warrior CreateWarrior()
		{
			return new IceWarrior("Ice Warrior", 250, 10);
		}

	}
}
