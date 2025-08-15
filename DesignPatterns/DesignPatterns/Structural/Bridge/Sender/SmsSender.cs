using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Sender
{
	public class SmsSender : INotificationSender
	{
		public void Send(string message)
		{
            Console.WriteLine($"[SMS] {message}");
        }
	}
}
