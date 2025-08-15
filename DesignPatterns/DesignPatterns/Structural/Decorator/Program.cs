using DesignPatterns.DesignPatterns.Structural.Decorator.Repository;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator
{
	 class Program
	{
		static void Main(string[] args)
		{
			var services = new ServiceCollection();

			services.AddLogging(config =>
			{
				config.AddConsole();
				config.SetMinimumLevel(LogLevel.Information);
			});

			services.AddScoped<IUserRepository, UserRepository>();
			services.Decorate<IUserRepository, LoggingUserRepository>();

			var provider = services.BuildServiceProvider();

			//var repo = provider.GetRequiredService<IUserRepository>();
			//repo.Add(new User { Id = 1, Name = "Roman" });
			//var user = repo.GetById(1);

			//Console.WriteLine($"Result: {user?.Name}");
		}

	}
}
