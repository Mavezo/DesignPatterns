using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Observer
{
	public class Logger
	{
		private readonly List<ILogObserver> logObserversList = new();

		public void Subscribe(ILogObserver observer)
		{
			logObserversList.Add(observer);
		}
		public void Unsubscribe(ILogObserver observer)
		{
			logObserversList.Remove(observer);
		}
		public void Log(string message, LogLevel level)
		{
			Console.WriteLine($"[Logger] {level}: {message}");
        }

		public void NotifyObservers(string message, LogLevel level)
		{
            foreach (var observer in logObserversList)
            {
				observer.OnLog(message, level);
            }
        }

	}
}
