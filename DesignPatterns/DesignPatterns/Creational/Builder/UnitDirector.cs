using DesignPatterns.DesignPatterns.Creational.Builder.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder
{
	public class UnitDirector
	{
		public Unit CreateDefaultWarrior(IUnitBuilder builder)
		{
			return builder
				.SetName("Conan")
				.SetHP(250)
				.SetDamage(25)
				.SetWeapon("Sword")
				.Build();
		}

		public Unit CreateDefaultMage(IUnitBuilder builder)
		{
			return builder
				.SetName("Gandalf")
				.SetHP(100)
				.SetDamage(40)
				.SetWeapon("Staff")
				.Build();
		}

	}
}
