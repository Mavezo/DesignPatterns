using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Base
{
	public abstract class Unit
	{
		public string Name { get; protected set; }
		public int Health { get; protected set; }
		public int Damage { get; protected set; }
		public string Weapon { get; protected set; }
		public string Class { get; protected set; }

		public override string ToString()
		{
			return $"{Class} {Name} — HP: {Health}, DMG: {Damage}, Weapon: {Weapon}";
		}
	}

}
