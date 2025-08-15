using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Repository
{
	//Base decorator
	public class LoggingUserRepository : IUserRepository
	{
		private readonly IUserRepository innerRepository;
		private readonly ILogger<LoggingUserRepository> logger;

		public LoggingUserRepository(IUserRepository innerRepository, ILogger<LoggingUserRepository> logger)
		{
			this.innerRepository = innerRepository;
			this.logger = logger;
		}

		public void Add(User user)
		{
			logger.LogInformation($"Adding user: {user.Name}");
			innerRepository.Add(user);
		}

		public User? GetById(int id)
		{
			logger.LogInformation($"Getting user with ID: {id}");
			return innerRepository.GetById(id);
		}
	}
}
