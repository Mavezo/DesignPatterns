using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Observer.Observers
{
	public class EmailAlertObserver : ILogObserver
	{
		public void OnLog(string message, LogLevel level)
		{
			if (level == LogLevel.Critical)
			{
				Console.WriteLine($"[Email] Sending critical alert: {message}");
            }
		}
	}
}
