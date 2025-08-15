using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Repository
{
	public interface IUserRepository
	{
		User? GetById(int id);
		void Add(User user);
	}
}
