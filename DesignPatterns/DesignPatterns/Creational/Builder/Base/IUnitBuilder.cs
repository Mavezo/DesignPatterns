using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Base
{
	public interface IUnitBuilder
	{
		IUnitBuilder SetName(string name);
		IUnitBuilder SetHP(int hp);
		IUnitBuilder SetDamage(int damage);
		IUnitBuilder SetWeapon(string weapon);
		Unit Build();
	}
}
