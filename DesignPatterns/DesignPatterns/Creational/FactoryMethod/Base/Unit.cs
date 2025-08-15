using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Base
{
	public abstract class Unit
	{

		public string Name { get; set; }
		public int Health { get; set; }
		public Unit(string name, int health)
		{
			Name = name;
			Health = health;
		}
	}
}
