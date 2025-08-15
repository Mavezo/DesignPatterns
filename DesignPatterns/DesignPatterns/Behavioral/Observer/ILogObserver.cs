using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Behavioral.Observer
{
	public interface ILogObserver
	{
		void OnLog(string message, LogLevel level);
	}
}
