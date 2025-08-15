using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base;
using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Mages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Units.Mages.Creators
{
	public class FireMageCreator : MageCreator
	{
		public override Mage CreateMage()
		{
			return new FireMage("FireMage", 30, 75, 20);
		}
	}
}
