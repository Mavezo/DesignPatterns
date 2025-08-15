using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Units.Mages.Creators
{
	public  class MageCreator
	{
		public virtual Mage CreateMage() {
			return new Mage("Name", 50, 50, 50);
		}
	}
}
