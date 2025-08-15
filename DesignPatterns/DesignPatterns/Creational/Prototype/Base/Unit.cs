using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Base
{
	public abstract class Unit : IPrototype<Unit>
	{

		public string Name { get; set; }
		public int Health { get; set; }
		public Unit(string name, int health)
		{
			Name = name;
			Health = health;
		}
		public Unit(Unit prototype)
		{
			Name = prototype.Name;
			Health = prototype.Health;
		}
		public abstract Unit Clone();
	}
}
