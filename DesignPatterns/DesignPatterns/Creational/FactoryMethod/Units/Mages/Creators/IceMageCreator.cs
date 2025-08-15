using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base;
using DesignPatterns.DesignPatterns.Creational.FactoryMethod.IceUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Units.Mages.Creators
{
	public class IceMageCreator : MageCreator
	{
		public override Mage CreateMage()
		{
			return new IceMage("IceMage", 50, 50, 50);
		}
	}
}
