using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Observer.Observers
{
	public class ConsoleLogObserver : ILogObserver
	{
		public void OnLog(string message, LogLevel level)
		{
			Console.WriteLine($"[Console]	 {level}: {message}");
        }
	}
}
