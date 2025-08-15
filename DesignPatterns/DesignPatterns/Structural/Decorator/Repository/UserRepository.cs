using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Repository
{
	internal class UserRepository : IUserRepository
	{
		private readonly DbContext context;

		public UserRepository(DbContext context)
		{
			this.context = context;
		}

		public void Add(User user)
		{
			context.Set<User>().Add(user);
			context.SaveChanges();
		}

		public User? GetById(int id)
		{
			return context.Set<User>().Find(id);
		}
	}
}
