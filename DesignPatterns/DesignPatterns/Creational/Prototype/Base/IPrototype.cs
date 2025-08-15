using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Base
{
	public interface IPrototype<T>
	{
		T Clone();
	}
}
